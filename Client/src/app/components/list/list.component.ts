import {Component, Input} from '@angular/core';
import { List } from '../../interfaces/List';
import {ListService} from "../../services/list/list.service";
import {CardService} from "../../services/card/card.service";
import {Card} from "primeng/card";
import {Board} from "../../interfaces/Board";

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [],
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent {
  @Input() listBoard!: List;
  cards:Card[] = []
  constructor(private service:CardService) {
  }
  ngOnInit(){
    this.service.getByListId(`https://localhost:7082/list=${this.listBoard.id}`)
      .subscribe((cards:Card[])=>{
        this.cards = cards;
        console.log(this.cards);
      });
  }
}
