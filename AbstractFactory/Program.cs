namespace AbstractFactory
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory.Factories;

    public class Program
    {
        public static void Main()
        {
            var alfredo = new AlfreddosPlace();
            var luidji = new LuidjiSpagettiPlace();

            var onlinePizzaPlace = new OnlineDeliveryCompany(alfredo, luidji);
            var peperoni = onlinePizzaPlace.MakePeperoni();
            var carbonara = onlinePizzaPlace.MakeCarbonara();

            Console.WriteLine(peperoni);
            Console.WriteLine(carbonara);
        }
    }
}
