import { Component, NgModule } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CardComponent } from './card/card.component';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

// @NgModule({
//   declarations: [
//     AppComponent,
//     CardComponent
//   ],
//   imports: [
//     BrowserModule,
//     HttpClientModule 
//   ],
//   providers: [],
//   bootstrap: [AppComponent]
// })
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CardComponent, CommonModule, HttpClientModule ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Fronted';
}
