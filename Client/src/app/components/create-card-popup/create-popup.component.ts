import {Component, EventEmitter, Input, Output} from '@angular/core';
import {DialogModule} from "primeng/dialog";
import {CommonModule} from "@angular/common";
import {Card} from "../../interfaces/Card";
import {ButtonDirective} from "primeng/button";
import {FormsModule} from "@angular/forms";

@Component({
  selector: 'app-create-card-popup',
  standalone: true,
  imports: [DialogModule, CommonModule, ButtonDirective, FormsModule],
  templateUrl: './create-popup.component.html',
  styleUrl: './create-popup.component.scss'
})
export class CreatePopupComponent {
  @Input() display:boolean = false;
  @Input() header!:string;
  @Output() create = new EventEmitter<Card>();
  @Output() cancel = new EventEmitter<void>();

  @Input() card:Card = {
    id:0,
    title:'',
    description:'',
    deadline:''
  };
  onCreate(){
    this.create.emit();
  }
  onCancel(){
    this.display = false;
  }
}
