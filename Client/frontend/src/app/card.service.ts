import { Injectable } from '@angular/core';
import { Card } from './Card';
import { HttpClient, HttpHandler } from '@angular/common/http';
import { TextConstatns } from './TextConstants';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardService {

  constructor(private http:HttpClient) { }

  private readonly constants=new TextConstatns();
  private cardlist!:Card[];
  async fetchCards(){
    
    await this.http.get<Card[]>(this.constants.CardUrl()).subscribe(cards=>{
      this.cardlist=cards;
    });
    return this.cardlist
  }

  // async getAllCards(): Promise<Card[]>{
  //   const data= await this.http.post();
  // }
  // getCardById(Id:number): Card | undefined{
  //   return this.CardList.find(c=>
  //     c.Id===Id
  //   );
  // }
  // submitApplication(cardTitle:string,cardDescriprion:string){
  //   console.log(cardTitle,cardDescriprion);
  //   this.CardList.push({
  //     Id: this.CardList.length+1,
  //     Title: cardTitle,
  //     Description: cardDescriprion
  //   })
  // }
}
