import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Producto } from './interfaces/Producto';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductosService {

  constructor(private http: HttpClient) { }

  productos :Producto[] =[];

  BaseUrl = 'https://localhost:7271/api';


  getProductos():Observable<Producto[]>{
    return this.http.get<Producto[]>(`${this.BaseUrl}/Productoes`);
  }

}
