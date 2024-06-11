import { Component } from '@angular/core';
import {BoardService} from "../services/board/board.service";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
  constructor(
    private service: BoardService
  ) {
  }
  ngOnInit(){
    this.service.getAll('https://localhost:7082/api/Board',
      {page:0,perPage:0})
      .subscribe((boards)=>{
    console.log(boards);
    });
  }
}
