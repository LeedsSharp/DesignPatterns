namespace StrategyPattern.Tests
{
    public class StrategyDeliveryService : IDeliveryService
    {
        private readonly IDeliveryCostStrategy strategy;

        public StrategyDeliveryService(IDeliveryCostStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double CalculateDeliveryCost(Order order)
        {
            return strategy.Calculate(order);

            /* No need to throw an UnknowDeliveryMethodException,
             * because a strategy is always passed
             */
        }
    }
}