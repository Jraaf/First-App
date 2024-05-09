import { HttpClient } from "@angular/common/http";
import { Observable, map } from "rxjs";
import { Card } from "./card";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
  })
export class CardService {
    
  private apiUrl = 'https://localhost:7082/api/Cards';

  constructor(private http: HttpClient) {}

  // Fetch a single card by Id
  getCard(id: number): Observable<Card> {
    return this.http.get<Card>(`${this.apiUrl}/${id}`).pipe(
      map(card => this.mapCard(card))
    );
  }

  // Fetch all cards
  getAllCards(): Observable<Card[]> {
    return this.http.get<Card[]>(this.apiUrl).pipe(
      map(cards => cards.map(card => this.mapCard(card)))
    );
  }

  // Map JSON response to Card interface
  private mapCard(card: any): Card {
    return {
      Id: card.id,
      Title: card.title,
      Description: card.description
    };
  }
}
