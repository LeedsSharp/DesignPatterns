namespace StrategyPattern.Tests
{
    public static class OrderFactory
    {
        public static Order CreateRoyalMailOrder()
        {
            return new Order { DeliveryMethodName = "Royal Mail" };
        }

        public static Order CreateTNTOrder()
        {
            return new Order { DeliveryMethodName = "TNT" };
        }

        public static Order CreateDHLOrder()
        {
            return new Order { DeliveryMethodName = "DHL" };
        }
    }
}