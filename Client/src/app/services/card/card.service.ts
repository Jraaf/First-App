import { Injectable } from '@angular/core';
import {ApiService} from "../api.service";
import {Observable} from "rxjs";
import {Card} from "../../interfaces/Card";

@Injectable({
  providedIn: 'root'
})
export class CardService {

  constructor(
    private apiService: ApiService
  ) { }

  getByListId = (url: string): Observable<Card[]> => {
    return this.apiService.get(url);
  }
  getById = (url: string): Observable<Card> => {
    return this.apiService.get(url);
  }
}
