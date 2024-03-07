import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Customer } from './models/Customer';
import { CustomerService } from './services/customer.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'CustomerCRUD.UI';
  customers : Customer[]=[];

  constructor(private customerService: CustomerService){

  }

  ngOnInit() : void{
    this.customers = this.customerService.getCustomers();
    console.log(this.customers);
  }
}
