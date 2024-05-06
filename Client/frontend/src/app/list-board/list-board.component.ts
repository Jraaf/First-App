import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from '../card/card.component';
import { Card } from '../Card';

@Component({
  selector: 'app-list-board',
  standalone: true,
  imports: [CommonModule,CardComponent],
  templateUrl: './list-board.component.html',
  styleUrl: './list-board.component.scss'
})
export class ListBoardComponent {

}
