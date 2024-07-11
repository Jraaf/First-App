import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(
    private httpClient: HttpClient,
  ) { }

  get<T>(url: string): Observable<T> {
    return this.httpClient.get(url,{}) as Observable<T>;
  }
  post<T>(url: string, body: T): Observable<T> {
    return this.httpClient.post(url, body,{}) as Observable<T>;
  }
  put<T>(url: string, body: T): Observable<T> {
    return this.httpClient.put(url, body,{}) as Observable<T>;
  }
  delete<T>(url: string): Observable<T> {
    return this.httpClient.delete(url, {}) as Observable<T>;
  }
}
