export type Questions = Question[];

export interface Question {
    id: number;
    content: string;
    answers: Answer[];
}

export interface Answer {
    id: number;
    content: string;
    rate: number;
}



// {
//     "id": 1,
//     "content": "You’re really busy at work and a colleague is telling you their life story and personal woes. You:",
//     "answers": [
//       {
//         "id": 4,
//         "questionId": 1,
//         "content": "Interrupt and explain that you are really busy at the moment",
//         "rate": 0
//       }
//     ]
//   },