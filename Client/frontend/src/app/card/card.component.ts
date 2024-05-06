import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListBoardComponent } from '../list-board/list-board.component';
import { Card } from '../Card';

@Component({
  selector: 'app-card',
  standalone: true,
  imports: [CommonModule,ListBoardComponent],
  templateUrl:'./card.component.html',
  styleUrl: './card.component.scss'
})
export class CardComponent {
  @Input() card!:Card;
  cardList: Card[] = [
    {
      "Id":0,
      "Title":"Card name",
      "Description":"put description here"    
    },
    {
      "Id":1,
      "Title":"Card name",
      "Description":"put description here"    
    },
    {
      "Id":2,
      "Title":"Card name",
      "Description":"put description here"    
    },
  ];
}
