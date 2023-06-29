import { Component } from '@angular/core';
import { InventoryService, Item } from '../services/Inventory.service';
@Component({
  selector: 'app-items',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ProductComponent {
  items: Item[] = [];

  constructor(private inventoryService: InventoryService) { }

  ngOnInit() {
    this.inventoryService.getItems().subscribe(data => {
      this.items = data;
    });
  }
}
