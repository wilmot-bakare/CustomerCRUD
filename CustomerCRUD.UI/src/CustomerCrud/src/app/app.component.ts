import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Customer } from './models/customer';
import { CustomerService } from './services/customer.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'CustomerCrud';
  customers : Customer[]=[];
  customerToEdit? : Customer;

  constructor(private customerService: CustomerService){

  }
  ngOnInit() : void{
    this.customerService.getCustomers()
    .subscribe((result:Customer[])=>(this.customers=result));
     console.log(this.customers);
   }

   addCustomer(){
    this.customerToEdit = new Customer();
  }
   updateCustomer(customer:Customer){
    this.customerToEdit = customer;
   }
   
}
