using CustomerCRUD.Core.DTOs;
using CustomerCRUD.Core.Models;
using CustomerCRUD.Service.CustomerServices.Implementations;
using CustomerCRUD.Service.CustomerServices.Interfaces;

namespace CustomerCRUD.Test
{
    [TestClass]
    public class CustomerServiceTests
    {
        private ICustomerService _customerService;

        [TestInitialize]
        public void Initialize()
        {
            _customerService = new CustomerService();
        }

        [TestMethod]
        public void AddCustomer_ShouldAddCustomerToList()
        {
            // Arrange
            CustomerDTO customer = new CustomerDTO
            {
                Name = "Will Mot",
                Age = 30,
                PostCode = "ADF123",
                Height = 1.75
            };

            // Act
           var addedCustomer =  _customerService.AddCustomer(customer);

            // Assert
            CollectionAssert.Contains(_customerService.Customers, addedCustomer);
        }

        [TestMethod]
        public void UpdateCustomer_ExistingCustomer_ShouldUpdateCustomer()
        {
            // Arrange
            CustomerDTO existingCustomer = new CustomerDTO
            {
                Name = "Mary Maye",
                PostCode = "ADF123",
                Age = 40,
                Height = 1.80
            };

           var addedCustomer =  _customerService.AddCustomer(existingCustomer);

            Customer updatedCustomer = new Customer
            {
                Id = addedCustomer.Id,
                Name = "Mary May",
                Age = 35,
                Height = 1.85
            };

            // Act
            _customerService.UpdateCustomer(updatedCustomer);

            // Assert
            Customer retrievedCustomer = _customerService.Customers.Find(c => c.Id == updatedCustomer.Id);
            Assert.IsNotNull(retrievedCustomer);
            Assert.AreEqual(updatedCustomer.Name, retrievedCustomer.Name);
            Assert.AreEqual(updatedCustomer.Age, retrievedCustomer.Age);
            Assert.AreEqual(updatedCustomer.Height, retrievedCustomer.Height);
        }

        [TestMethod]
        public void UpdateCustomer_NonExistingCustomer_ShouldThrowArgumentException()
        {
            // Arrange
            Customer nonExistingCustomer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "John Dan",
                Age = 45,
                Height = 1.90
            };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _customerService.UpdateCustomer(nonExistingCustomer));
        }
    }
}