﻿using CustomerCRUD.Core.DTOs;
using CustomerCRUD.Core.Models;
using CustomerCRUD.Service.CustomerServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomerCRUD.Service.CustomerServices.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers;
        public CustomerService()
        {
            _customers = new List<Customer>();
        }

        public List<Customer> Customers => _customers;

        public Customer AddCustomer(CustomerDTO customerDto)
        {
            Customer customer = new Customer();
            customer.Age= customerDto.Age;
            customer.Name= customerDto.Name;
            customer.PostCode= customerDto.PostCode;
            customer.Height= customerDto.Height;
            _customers.Add(customer);
            return customer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
           Customer existingCustomer = _customers.FirstOrDefault(c=>c.Id == customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Age= customer.Age;
                existingCustomer.Name= customer.Name;
                existingCustomer.Height= customer.Height;
                return customer;
            }
            else 
            { 
                throw new ArgumentException($"Customer with Id {customer.Id} not found."); 
            }
        }
    }
}
