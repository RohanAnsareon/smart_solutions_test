import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Questions } from './model';
import { QuestionsService } from './questions.service';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.scss']
})
export class QuestionsComponent implements OnInit {
  questions: Questions = [];

  questionsForm = new FormGroup({});

  constructor(private questionsService: QuestionsService, private router: Router) { }

  ngOnInit(): void {
    this.questionsService.getQuestions()
      .subscribe({
        next: questions => {
          this.questions = questions;

          this.questionsForm.addControl('questions', new FormArray(questions.map(q => new FormGroup({
            id: new FormControl(q.id),
            answer: new FormControl('', Validators.required)
          }))))
        },
        error: err => console.log(err)
      })
  }

  handleSubmit() {
    if (this.questionsForm.valid) {
      const val = this.questionsForm.value as { questions: { id: number, answer: number }[] };

      let sum = 0;

      val.questions.forEach(q => {
        sum += q.answer;
      });

      sum = Math.floor((sum / val.questions.length) * 10);

      this.router.navigate(['/result', sum]);
    } else {
      console.log('Form is invalid');
    }
  }

  getStepControl(i: number) {
    return this.questionsForm.get('questions')?.get([i]) as AbstractControl;
  }
}
