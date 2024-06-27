import {Component, Input} from '@angular/core';
import { List } from '../../interfaces/List';
import {CardService} from "../../services/card/card.service";
import {CardComponent} from "../card/card.component";
import {NgForOf} from "@angular/common";
import {Card} from "../../interfaces/Card";

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [
    CardComponent,
    NgForOf
  ],
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
