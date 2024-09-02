import { Routes } from '@angular/router';
import { ProductComponent } from './components/product/product.component';
import { CategoryComponent } from './components/category/category.component';
import { ProductAddComponent } from './components/product-add/product-add.component';

export const routes: Routes = [
    {path:"",pathMatch:"full", component:ProductComponent},
    {path:"products", component:ProductComponent},
    {path:"categories", component:CategoryComponent},
    {path:"products/category/:categoryId", component:ProductComponent},
    {path:"products/add", component:ProductAddComponent}
  ];
