using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;

namespace CustomerOrderServiceTesting
{
    [TestFixture]
    public class CustomerOrderServiceTests
    {
        [TestCase]
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 101,
                CustomerName = "Saikumar",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 123,
                ProductId = 22,
                ProductQuantity = 9,
                Amount = 150
            };

            CustomerorderService customerOrderService = new CustomerorderService();

            //Act
            customerOrderService.ApplyDiscount(premiumCustomer, order);

            //Assert
            Assert.AreEqual(order.Amount, 135);
        }

        [TestCase]
        
        public void When_SpecialCustomer_Expect_20PercentDiscount()
        {
            //Arrange
            Customer specialCustomer = new Customer
            {
                CustomerId = 102,
                CustomerName = "venkat",
                CustomerType = CustomerType.SpecialCustomer
            };

            Order order = new Order
            {
                OrderId = 39,
                ProductId = 29,
                ProductQuantity = 6,
                Amount = 250
            };

            CustomerorderService customerOrderService = new CustomerorderService();

            //Act
            customerOrderService.ApplyDiscount(specialCustomer, order);

            //Assert
            Assert.AreEqual(order.Amount, 200);
        }

    }

}
