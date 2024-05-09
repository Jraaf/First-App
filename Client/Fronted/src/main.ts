// app.module.ts
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; 
import { CardComponent } from './app/card/card.component'; 

@NgModule({
  declarations: [
  ],
  imports: [
    BrowserModule,
    HttpClientModule  // Include this module here
  ],
  providers: []
})
export class AppModule { }
