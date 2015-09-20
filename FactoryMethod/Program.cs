namespace FactoryMethod
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Reflection;
    using FactoryMethod.Manufacturers;

    public class Program
    {
        public static void Main()
        {
            WorkWithPhone(new Samsung());

            WorkWithPhone(new Apple());
        }

        private static void WorkWithPhone(Manufacturer manifacturer)
        {
            var phone = manifacturer.ManufactureGsm();
            Console.WriteLine(phone.ToString());
            Console.WriteLine(phone.Start());
        }
    }
}
