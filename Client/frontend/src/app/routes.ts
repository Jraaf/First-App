import { Routes } from "@angular/router";
import { ListBoardComponent } from "./list-board/list-board.component";

const routeConfig: Routes = [
    {
        path:'',
        component:ListBoardComponent,
        title:'Your tasks'
    }
];

export default routeConfig;