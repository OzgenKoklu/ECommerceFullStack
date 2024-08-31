import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  product:any = {productId:1, productName:'Bardak', categoryId:2, unitPrice:5};
  product2:any = {productId:2, productName:'Kamera', categoryId:2, unitPrice:5};
  product3:any = {productId:3, productName:'Laptop', categoryId:2, unitPrice:5};
  product4:any = {productId:4, productName:'Klavye', categoryId:2, unitPrice:5};
  product5:any = {productId:5, productName:'Ekran', categoryId:2, unitPrice:5};
  products:any = [this.product, this.product2, this.product3, this.product4, this.product5];
}
