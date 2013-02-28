using NUnit.Framework;

namespace StrategyPattern.Tests
{
    [TestFixture]
    public class DeliveryServiceTests
    {
        // NOTE: A common naming convention for Unit Tests is MethodName_StateUnderTest_ExpectedBehavior

        [Test]
        public void CalculateDeliveryCost_with_Royal_Mail_Order_returns_199()
        {
            // Arrange
            var deliveryService = new SwitchDeliveryService();
            var order = OrderFactory.CreateRoyalMailOrder();

            // Act
            var cost = deliveryService.CalculateDeliveryCost(order);

            // Assert
            Assert.AreEqual(1.99d, cost);
        }

        [Test]
        public void CalculateDeliveryCost_with_TNT_Order_returns_578()
        {
            // Arrange
            var deliveryService = new SwitchDeliveryService();
            var order = OrderFactory.CreateTNTOrder();

            // Act
            var cost = deliveryService.CalculateDeliveryCost(order);

            // Assert
            Assert.AreEqual(5.78d, cost);
        }

        [Test]
        public void CalculateDeliveryCost_with_DHL_Order_returns_749()
        {
            // Arrange
            var deliveryService = new SwitchDeliveryService();
            var order = OrderFactory.CreateDHLOrder();

            // Act
            var cost = deliveryService.CalculateDeliveryCost(order);

            // Assert
            Assert.AreEqual(7.49d, cost);
        }
    }
}