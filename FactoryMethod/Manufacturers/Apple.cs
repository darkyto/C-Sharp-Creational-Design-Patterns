namespace FactoryMethod.Manufacturers
{
    using System;
    using System.Collections.Generic;
    using FactoryMethod.Products;

    public class Apple : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            var phone = new IPhone6() { BatteryLife = 1000, Height = 200, Weight = 100, Width = 50 };

            return phone;
        }
    }
}
