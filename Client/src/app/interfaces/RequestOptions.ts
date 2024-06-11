import {HttpContext, HttpHeaders, HttpParams} from "@angular/common/http";

export interface  requestOptions {
  headers?: HttpHeaders | {
    [header: string]: string | string[];
};
  context?: HttpContext;
  observe?: 'body';
  params?: HttpParams | {
    [param: string]: string | number | boolean | ReadonlyArray<string | number | boolean>;
};
  reportProgress?: boolean;
  responseType: 'json';
  withCredentials?: boolean;
  transferCache?: {
    includeHeaders?: string[];
  } | boolean;
}
export interface PaginationParams{
  [param: string]: string | number | boolean | ReadonlyArray<string | number | boolean>;
  page:number;
  perPage:number;
}
