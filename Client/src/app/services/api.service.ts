import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {requestOptions} from "../interfaces/RequestOptions";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(
    private httpClient: HttpClient,
  ) { }

  getAll<T>(url: string, options:requestOptions): Observable<T> {
    return this.httpClient.get(url, options) as Observable<T>;
  }
}
