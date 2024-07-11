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
    this.fetchAll();
  }
  fetchAll(){
    this.service.get('https://localhost:7082/api/Board')
      .subscribe((boards:Board[])=>{
        this.boards = boards;
        console.log(this.boards);
      });
  }
  edit(board:Board,id:number){
    this.service.edit(`https://localhost:7082/api/Board?id=${id}`,board).subscribe(
      {
        next:(data)=>{
          console.log(data);
          this.fetchAll();
        },
        error:(err)=>console.log(err)
      }
    );
  }
  delete(id:number){
    this.service.delete(`https://localhost:7082/api/Board/${id}`).subscribe(
      {
        next:(data)=>{
          console.log(data);
          this.fetchAll();
        },
        error:(err)=>console.log(err)
      }
    );
  }
  add(board:Board){
    this.service.add(`https://localhost:7082/api/Board`,board).subscribe(
      {
        next:(data)=>{
          console.log(data);
          this.fetchAll();
        },
        error:(err)=>console.log(err)
      }
    );
  }
}
