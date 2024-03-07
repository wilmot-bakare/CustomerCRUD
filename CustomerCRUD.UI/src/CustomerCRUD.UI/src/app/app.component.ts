import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Customer } from './models/customer';
import { CustomerService } from './services/customer.service';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import {MatTableModule} from '@angular/material/table';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CommonModule,HttpClientModule,MatTableModule,FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'CustomerCRUD.UI';
  customers : Customer[]=[];

  constructor(private customerService: CustomerService){

  }

  ngOnInit() : void{
   this.customerService.getCustomers()
   .subscribe((result:Customer[])=>(this.customers=result));
    console.log(this.customers);
  }
}
