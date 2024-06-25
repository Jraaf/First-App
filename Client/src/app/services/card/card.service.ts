import { Injectable } from '@angular/core';
import {ApiService} from "../api.service";
import {Observable} from "rxjs";
import {List} from "../../interfaces/List";
import {Card} from "primeng/card";

@Injectable({
  providedIn: 'root'
})
export class CardService {

  constructor(
    private apiService: ApiService
  ) { }

  getByListId = (url: string): Observable<Card[]> => {
    return this.apiService.getAll(url);
  }
}
