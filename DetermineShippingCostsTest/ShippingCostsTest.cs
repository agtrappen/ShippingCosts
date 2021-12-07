using DetermineShippingCosts;
using NUnit.Framework;

namespace DetermineShippingCostsTest
{

    public class ShippingCostsTest
    {
        [Test]
        public void ShippingCosts_CalculateShippingCostsTrue()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 150;              // Total costs of user's order
            string typeOfShipping = "Ground";       // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);
            
            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            
            Assert.Equals(2500, totalCosts);
        }

        [Test]
        public void ShippingCosts_CalculateShippingCostsFalse()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 150;              // Total costs of user's order
            string typeOfShipping = "Ground";       // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(false, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(150, totalCosts);
        }

        [Test]
        public void ShippingCosts_TotalPriceHigh_TypeGround()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 15000;            // Total costs of user's order
            string typeOfShipping = "Ground";       // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(15000, totalCosts);
        }

        [Test]
        public void ShippingCosts_TotalPriceLow_TypeGround()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 150;              // Total costs of user's order
            string typeOfShipping = "Ground";       // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(250, totalCosts);
        }

        [Test]
        public void ShippingCosts_TotalPriceLow_TypeInStore()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 150;              // Total costs of user's order
            string typeOfShipping = "InStore";      // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(200, totalCosts);
        }

        [Test]
        public void ShippingCosts_TotalPriceLow_TypeNextDayAir()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 150;              // Total costs of user's order
            string typeOfShipping = "NextDayAir";   // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(400, totalCosts);
        }

        [Test]
        public void ShippingCosts_TotalPriceLow_TypeSecondayDayAir()
        {
            // Arrange
            double totalCosts = 0;                      // Total amount user has to pay.
            double priceOfOrder = 150;                  // Total costs of user's order
            string typeOfShipping = "SecondayDayAir";   // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(275, totalCosts);
        }

        [Test]
        public void ShippingCosts_TotalPriceLow_TypeFakeMethod()
        {
            // Arrange
            double totalCosts = 0;                  // Total amount user has to pay.
            double priceOfOrder = 150;              // Total costs of user's order
            string typeOfShipping = "FakeMethod";   // Type of shipping

            // Act
            Shipping shippingCosts = new Shipping();
            totalCosts = shippingCosts.ShippingCosts(true, typeOfShipping, priceOfOrder);

            // Add ordering costs to shipping costs
            totalCosts += priceOfOrder;

            // Assert
            Assert.Equals(150, totalCosts);
        }
    }
}
