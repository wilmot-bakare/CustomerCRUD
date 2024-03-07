import { Injectable } from '@angular/core';
import { Customer } from '../models/customer';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {environment} from '../../environments/environment'

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  private getCustomerUrl="Customer/GetCustomers"
  addCustomerUrl="Customer/AddCustomers"
  updateCustomerUrl="Customer/UpdateCustomers"
    constructor(private http:HttpClient) { }
  
    public getCustomers(): Observable< Customer[]> {
  
      return this.http.get<Customer[]>(`${environment.apiUrl}/${this.getCustomerUrl}`)
    }
  }
