namespace StrategyPattern.Tests
{
    public class SwitchDeliveryService : IDeliveryService
    {
        public double CalculateDeliveryCost(Order order)
        {
            switch (order.DeliveryMethodName)
            {
                case "Royal Mail":
                    return CalculateUsingRoyalMailAlgorithm(order);
                case "TNT":
                    return CalculateUsingTNTAlgorithm(order);
                case "DHL":
                    return CalculateUsingDHLAlgorithm(order);
                default:
                    throw new UnknownDeliveryMethodException();
            }

            /* Problems with this approach:
             * Adding a new delivery method means modifying this code,
             * which breaks the Open/Close Principle
             */
        }

        /* Problem with this approach:
         * 1) Not very good separation of concerns
         * 2) Changing one algorithm may impact other algorithms
         * 3) It would be better if we could do calculations independently of the DeliveryService class
         */

        // Strategy 1
        private double CalculateUsingRoyalMailAlgorithm(Order order)
        {
            /* Complex calculations based on weight tables and package dimensions
             * perhaps accessing a database or third party web service
             * ...
             */
            return 1.99d;
        }

        // Strategy 2
        private double CalculateUsingTNTAlgorithm(Order order)
        {
            /* Complex calculations based on weight tables and package dimensions
             * perhaps accessing a database or third party web service
             * ...
             */
            return 5.78d;
        }

        // Strategy 3
        private double CalculateUsingDHLAlgorithm(Order order)
        {
            /* Complex calculations based on weight tables and package dimensions
             * perhaps accessing a database or third party web service
             * ...
             */
            return 7.49d;
        }
    }
}