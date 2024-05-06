import { Card } from "./Card";

export interface ListBoard {
    Id: number; 
    Title: string; 
    Description: string;
    cardList:Card[];
}
