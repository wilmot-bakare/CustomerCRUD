using CustomerCRUD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRUD.Service.CustomerServices.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> Customers { get; }
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
    }
}
