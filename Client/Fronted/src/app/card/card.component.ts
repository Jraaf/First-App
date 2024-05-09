import { Component, OnInit, inject } from '@angular/core';
import { Card } from '../card';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { subscribe } from 'diagnostics_channel';
import { CommonModule } from '@angular/common';
import { firstValueFrom } from 'rxjs';
import { error } from 'console';
import { CardService } from '../card-service';


@Component({
  selector: 'app-card',
  standalone: true,
  imports: [CommonModule,HttpClientModule],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent implements OnInit{
  cards: Card[] = [];


  constructor(private cardService: CardService) {}

  ngOnInit() {
    this.fetchCards();
  }

  fetchCards() {
    
    this.cardService.getAllCards().subscribe({
      next: (cards) => {
        this.cards = cards;
        console.log(this.cards)
      },
      error: (err) => {
        console.error('Error fetching cards:', err);
      }
    });
  }
}
