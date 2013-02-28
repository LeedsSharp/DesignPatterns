namespace StrategyPattern.Tests.Strategies
{
    public class TNTCostStrategy : IDeliveryCostStrategy
    {
        public double Calculate(Order order)
        {
            /* Complex calculations based on weight tables and package dimensions
             * perhaps accessing a database or third party web service
             * ...
             */
            return 0;
        }
    }
}