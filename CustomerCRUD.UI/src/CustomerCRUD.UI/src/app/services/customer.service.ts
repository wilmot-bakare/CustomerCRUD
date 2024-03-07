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
    // let customer = new Customer();
    // customer.id="674d3cb7-375f-46b0-8768-0611e32b07b5";
    // customer.age=40;
    // customer.height=2.00;
    // customer.postCode="ABD23";
    // customer.name="Gella";

    return this.http.get<Customer[]>(`${environment.apiUrl}/${this.getCustomerUrl}`)
  }
}
