import {Component, Input} from '@angular/core';
import {Board} from "../../interfaces/Board";

@Component({
  selector: 'app-board',
  standalone: true,
  imports: [],
  templateUrl: './board.component.html',
  styleUrl: './board.component.scss'
})
export class BoardComponent {
  @Input() board!: Board;
}
