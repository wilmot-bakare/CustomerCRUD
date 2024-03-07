import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Customer } from '../../models/customer';
import { CustomerService } from '../../services/customer.service';

@Component({
  selector: 'app-edit-customer',
  templateUrl: './edit-customer.component.html',
  styleUrl: './edit-customer.component.css'
})
export class EditCustomerComponent {
  @Input() customer?:Customer;
  @Output() customerUpdated = new EventEmitter<Customer[]>();

  constructor(private customerService : CustomerService){}
  
  ngOnInit():void{
  }

  updateCustomer(customer:Customer){
    this.customerService.updateCustomers(customer)
    .subscribe((result:Customer)=>(this.customer=result));
  }
  addCustomer(customer:Customer){
    this.customerService.addCustomers(customer)
    .subscribe((result:Customer)=>(this.customer=result));
  }
}
