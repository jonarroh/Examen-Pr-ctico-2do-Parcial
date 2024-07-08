import { Component, signal, OnInit } from '@angular/core';
import { CardComponent } from './card/card.component';
import { NavComponent } from './nav/nav.component';
import { ProductosService } from './productos.service';
import { Categorias, Producto } from './interfaces/Producto';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-productos',
  standalone: true,
  imports: [
    CardComponent,
    NavComponent,
    FormsModule
  ],
  providers: [ProductosService],
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.css'] 
})
export class ProductosComponent implements OnInit {

  search = '';

  productos: Producto[] = [];
  filteredProductos: Producto[] = [];
  categorias = [
    'ALL',
    'MXN',
    'ENG',
    'USA'
  ]

  currentFilter = 'ALL';

  constructor(private productosService: ProductosService) {}

  changeFilter(filter: string) {
    this.currentFilter = filter;
    this.filteredProductos = this.productos.filter((producto) => {
      return filter === 'ALL' || producto.categoria === filter;
    });
  }


  searchProduct() {
    this.filteredProductos = this.productos.filter((producto) => {
      return producto.nombre.toLowerCase().includes(this.search.toLowerCase());
    });
  }

  ngOnInit(): void {
    this.productosService.getProductos().subscribe({
      next: (productos) => {
        this.productos = productos;
        console.log('productos', productos);
        this.changeFilter('ALL');
      },
      error: (error) => {
        console.log('error');
      },
      complete: () => {
        console.log('completo');
      }
    });
  }
}
