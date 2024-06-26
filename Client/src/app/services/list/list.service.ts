import { Injectable } from '@angular/core';
import {Observable} from "rxjs";
import {ApiService} from "../api.service";
import {List} from "../../interfaces/List";

@Injectable({
  providedIn: 'root'
})
export class ListService {

  constructor(private apiService: ApiService) { }

  getByBoardId = (url: string): Observable<List[]> => {
    return this.apiService.get(url);
  }
}
