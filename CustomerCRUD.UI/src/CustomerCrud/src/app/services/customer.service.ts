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
  private addCustomerUrl="Customer/AddCustomers"
  private updateCustomerUrl="Customer/UpdateCustomers"
    constructor(private http:HttpClient) { }
  
    public getCustomers(): Observable< Customer[]> {
  
      return this.http.get<Customer[]>(`${environment.apiUrl}/${this.getCustomerUrl}`)
    }

    public addCustomers(customer:Customer): Observable< Customer> {
  
      return this.http.post<Customer>(`${environment.apiUrl}/${this.addCustomerUrl}`,customer)
    }

    public updateCustomers(customer:Customer): Observable<Customer> {
  
      return this.http.put<Customer>(`${environment.apiUrl}/${this.updateCustomerUrl}`,customer)
    }
  }
