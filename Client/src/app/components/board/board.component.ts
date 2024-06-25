import {Component, Input} from '@angular/core';
import {Board} from "../../interfaces/Board";
import {CommonModule} from "@angular/common";
import {List} from "../../interfaces/List";
import {ListService} from "../../services/list/list.service";
import {ListComponent} from "../list/list.component";

@Component({
  selector: 'app-board',
  standalone: true,
  imports: [CommonModule, ListComponent],
  templateUrl: './board.component.html',
  styleUrl: './board.component.scss'
})
export class BoardComponent {
  constructor(private service:ListService) {
  }

  @Input() board!: Board;

  listBoards:List[] = [];
  ngOnInit(){
    this.service.getByBoardId(`https://localhost:7082/board=${this.board.id}`)
      .subscribe((listBoards:Board[])=>{
        this.listBoards = listBoards;
        console.log(this.listBoards);
      });
  }
}


