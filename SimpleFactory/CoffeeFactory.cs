namespace SimpleFactory
{
    using System;
    using System.Collections.Generic;

    public class CoffeeFactory
    {
        public Coffee GetCoffee(CoffeType coffeeType)
        {
            switch (coffeeType)
            {
                case CoffeType.Regular:
                    return new Coffee(0, 150);
                case CoffeType.Double:
                    return new Coffee(0, 200);
                case CoffeType.Cappuccino:
                    return new Coffee(100, 100);
                case CoffeType.Macchiato:
                    return new Coffee(200, 100);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
