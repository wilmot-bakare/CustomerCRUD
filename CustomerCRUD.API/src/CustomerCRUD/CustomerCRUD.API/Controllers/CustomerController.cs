using CustomerCRUD.Core.Models;
using CustomerCRUD.Service.CustomerServices.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        ILogger<CustomerController> _logger;
        public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger) {
            _customerService = customerService;
            _logger = logger;
        }

        [HttpPost("AddCustomers")]
        public async Task<ActionResult<Customer>> AddCustomers(Customer customer)
        {
            try
            {
                return Ok(_customerService.AddCustomer(customer));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the customer.");
            }
           
        }

        [HttpGet("GetCustomers")]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            try
            {
                return Ok(_customerService.Customers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching the customers.");
            }
           
        }

        [HttpPut("UpdateCustomers")]
        public async Task<ActionResult<Customer>> UpdateCustomers(Customer customer)
        {
            try
            {
                _customerService.UpdateCustomer(customer);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the customer.");
            }
        }
    }
}
