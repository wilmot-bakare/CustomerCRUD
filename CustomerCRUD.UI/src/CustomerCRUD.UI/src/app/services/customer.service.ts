import { Injectable } from '@angular/core';
import { Customer } from '../models/Customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor() { }

  public getCustomers(): Customer[] {
    let customer = new Customer();
    customer.id="674d3cb7-375f-46b0-8768-0611e32b07b5";
    customer.age=40;
    customer.height=2.00;
    customer.postCode="ABD23";
    customer.name="Gella";

    return [customer];
  }
}
