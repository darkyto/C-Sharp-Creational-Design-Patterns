namespace SimpleFactory
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var localCoffePlace = new CoffeeFactory();
            var regularCoffe = localCoffePlace.GetCoffee(CoffeType.Regular);

            Console.WriteLine("Regular coffee - Milk content: {0} ml, Coffee content: {1} ml", regularCoffe.MilkContent, regularCoffe.CoffeeContent);
        }
    }
}
