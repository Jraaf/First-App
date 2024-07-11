import { Injectable } from '@angular/core';
import {ApiService} from "../api.service";
import {Observable} from "rxjs";
import {Board} from "../../interfaces/Board";

@Injectable({
  providedIn: 'root'
})
export class BoardService {

  constructor(
    private apiService: ApiService
  ) { }

  get = (url: string): Observable<Board[]> => {
    return this.apiService.get(url);
  }
  edit=(url: string,body:any): Observable<Board> => {
    return this.apiService.put(url, body);
  }
  delete = (url:string):Observable<any>=>{
    return this.apiService.delete(url);
  }
  add = (url:string,body:Board):Observable<Board>=>{
    return this.apiService.post(url, body);
  }
}
