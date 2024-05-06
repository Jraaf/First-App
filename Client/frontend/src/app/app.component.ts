import { Component } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ListBoardComponent } from "./list-board/list-board.component";
import { RouterModule } from "@angular/router";

@Component({
  standalone: true,
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  imports: [ListBoardComponent,RouterModule],
})
export class AppComponent {
  title = 'frontend';

}
