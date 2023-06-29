import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})
export class InventoryService {

    constructor(private http: HttpClient) { }
    rootURL = 'https://localhost:7297';
    
    getItems() {
        return this.http.get<Item[]>(`${this.rootURL}/Inventory`);
    }
}

export interface Item{
    description: string;
    count: number;
}