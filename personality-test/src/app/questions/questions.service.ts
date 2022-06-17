import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Questions } from './model';

@Injectable({
  providedIn: 'root'
})
export class QuestionsService {

  private _result: number = 0;

  constructor(private client: HttpClient) { }

  getQuestions() {
    return this.client.get<Questions>(environment.apiBaseUrl + 'questionary/');
  }

  get result() {
    return this._result;
  }

  set result(res: number) {
    this._result = res;
  }
}
