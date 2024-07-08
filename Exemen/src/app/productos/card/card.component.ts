import { Component, input } from '@angular/core';

@Component({
  selector: 'product-card',
  standalone: true,
  imports: [],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent {

  url = input.required();
  nombre = input.required();
  categoria = input.required();
  precio = input.required();
  stock = input.required();

}
