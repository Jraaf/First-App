import { Routes } from "@angular/router";
import { ListBoardComponent } from "./list-board/list-board.component";
import { CardComponent } from "./card/card.component";

const routeConfig: Routes = [
    {
        path:'',
        component:ListBoardComponent,
        title:'Your tasks'
    },
    {
        path:'Card',
        component:CardComponent,
        title:'Your card'
    }
];

export default routeConfig;