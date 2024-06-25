import { Component } from '@angular/core';
import {BoardService} from "../services/board/board.service";
import {BoardComponent} from "../components/board/board.component";
import {Board} from "../interfaces/Board";
import {CommonModule} from "@angular/common";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    BoardComponent,
    CommonModule
  ],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
  constructor(private service: BoardService  ) {  }

  boards:Board[]=[];

  ngOnInit(){
    this.service.getAll('https://localhost:7082/api/Board')
      .subscribe((boards:Board[])=>{
        this.boards = boards;
        console.log(this.boards);
    });
  }
}
