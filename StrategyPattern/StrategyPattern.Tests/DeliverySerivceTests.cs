using NUnit.Framework;
using StrategyPattern.Tests.Strategies;

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
            var strategy = new RoyalMailCostStrategy();
            var deliveryService = new StrategyDeliveryService(strategy);
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
            var strategy = new TNTCostStrategy();
            var deliveryService = new StrategyDeliveryService(strategy);
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
            var strategy = new DHLCostStrategy();
            var deliveryService = new StrategyDeliveryService(strategy);
            var order = OrderFactory.CreateDHLOrder();

            // Act
            var cost = deliveryService.CalculateDeliveryCost(order);

            // Assert
            Assert.AreEqual(7.49d, cost);
        }
    }
}