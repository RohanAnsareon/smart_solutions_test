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
