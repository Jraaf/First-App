import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from '../card/card.component';
import { CardService } from '../card.service';
import { Card } from '../Card';
import { FormControl,FormGroup,ReactiveFormsModule } from '@angular/forms';
import { response } from 'express';

@Component({
  selector: 'app-list-board',
  standalone: true,
  imports: [CommonModule,CardComponent,ReactiveFormsModule],
  templateUrl: './list-board.component.html',
  styleUrl: './list-board.component.scss'
})
export class ListBoardComponent {
  cardList:Card[]=[];
  cardService:CardService=inject(CardService);

  async CardList(){
    let data=await this.cardService.fetchCards()
      .then(response.json)
    console.log(data)
  }
  constructor(){
    
  }
}
