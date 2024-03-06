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
            Customer customer = new Customer
            {
                Id = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                Name = "Will Mot",
                Age = 30,
                Height = 1.75
            };

            // Act
            _customerService.AddCustomer(customer);

            // Assert
            CollectionAssert.Contains(_customerService.Customers, customer);
        }

        [TestMethod]
        public void UpdateCustomer_ExistingCustomer_ShouldUpdateCustomer()
        {
            // Arrange
            Customer existingCustomer = new Customer
            {
                Id = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                Name = "Mary Maye",
                Age = 40,
                Height = 1.80
            };

            _customerService.AddCustomer(existingCustomer);

            Customer updatedCustomer = new Customer
            {
                Id = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
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