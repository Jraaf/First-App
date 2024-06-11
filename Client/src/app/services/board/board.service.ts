import { Injectable } from '@angular/core';
import {ApiService} from "../api.service";
import {Observable} from "rxjs";
import {Board} from "../../interfaces/Board";
import {PaginationParams} from "../../interfaces/RequestOptions";

@Injectable({
  providedIn: 'root'
})
export class BoardService {

  constructor(
    private apiService: ApiService
  ) { }

  getAll = (url: string,params:PaginationParams): Observable<Board[]> => {
    return this.apiService.getAll(url, {
      params,
      responseType: "json"
    });
  }
}
