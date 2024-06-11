import { Injectable } from '@angular/core';
import {ApiService} from "../api.service";

@Injectable({
  providedIn: 'root'
})
export class CardService {

  constructor(
    private apiService: ApiService
  ) { }

  // getAll = (url: string, params:Params): Observable<Card[]> => {
  //   return this.apiService.getAll(url, params);
  // }
}
