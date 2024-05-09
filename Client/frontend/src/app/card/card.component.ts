import { Component, Input, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListBoardComponent } from '../list-board/list-board.component';
import { Card } from '../Card';
import { CardService } from '../card.service';
import { ActivatedRoute } from '@angular/router';
import { FormControl,FormGroup,ReactiveFormsModule } from '@angular/forms';
import { TextConstatns } from '../TextConstants';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-card',
  standalone: true,
  imports: [CommonModule,ListBoardComponent,ReactiveFormsModule,HttpClientModule],
  templateUrl:'./card.component.html',
  styleUrl: './card.component.scss'
})
export class CardComponent {
  contstants:TextConstatns=new TextConstatns();
  route:ActivatedRoute=inject(ActivatedRoute);
  cardService:CardService=inject(CardService);
  cardDetails:Card|undefined;

  cardList!:Card[];
  async getAllCards(){
    return await this.cardService.fetchCards().then(result=>{
      this.cardList=result;
    }).catch(error=>{
      console.log(error);
    });
  }

  addForm = new FormGroup({
    Title: new FormControl(this.contstants.cardTitle()),
    Description: new FormControl(this.contstants.cardDescriprion())
  });
  

  constructor(private http: HttpClient){
    const Id=Number(this.route.snapshot.params['id']);
    // this.cardDetails=this.cardService.getCardById(Id);
    //this.cardList=this.cardService.getAllCards();
  }

  async submitApplication(){
    let _title=this.addForm.value.Title ?? this.contstants.cardTitle();
    let _description=this.addForm.value.Description ?? this.contstants.cardDescriprion();
    let body=this.addForm.value;
    await this.http.post(this.contstants.CardUrl(), body)
  }
}
