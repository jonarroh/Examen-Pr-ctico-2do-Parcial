import { Component, OnInit } from '@angular/core';
import { ProductosService } from '../productos/productos.service';
import { Producto } from '../productos/interfaces/Producto';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [],
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  principalProductos: Producto[] = [];

  constructor(private service: ProductosService) {}

  ngOnInit(): void {
    this.service.getProductos().subscribe((productos) => {
      this.principalProductos = productos.slice(0, 3);
      console.log(this.principalProductos, 'Productos');
    });
  }
}
