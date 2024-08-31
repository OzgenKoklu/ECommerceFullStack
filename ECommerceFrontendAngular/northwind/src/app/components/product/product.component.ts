import { CommonModule} from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Product } from '../../models/product';
import { ProductResponseModel } from '../../models/productResponseModel';
import { response } from 'express';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent implements OnInit{

  products:Product[] = [];
  apiUrl = "https://localhost:44305/api/products/getall";
  //productResponseModel:ProductResponseModel= {};

  constructor(private httpClient:HttpClient){}
  ngOnInit(): void {
    this.getProducts();
  }

  getProducts(){
   this.httpClient.get<ProductResponseModel>(this.apiUrl).subscribe((response) => {
    this.products = response.data
   });
  }
}
