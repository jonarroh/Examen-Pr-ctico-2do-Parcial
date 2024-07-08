export interface Producto {
  id: number;
  nombre: string;
  image: string;
  cantidad: number;
  categoria: Categorias;
  precio: number;
  descripcion: string;
}


export type Categorias = | "MXN" | "USA" | "ENG"