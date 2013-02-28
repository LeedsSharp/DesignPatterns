namespace StrategyPattern.Tests
{
    public interface IDeliveryCostStrategy
    {
        double Calculate(Order order);
    }
}