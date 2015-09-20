namespace FactoryMethod.Manufacturers
{
    using System;
    using System.Collections.Generic;
    using FactoryMethod.Manufacturers;
    using FactoryMethod.Products;

    public class Samsung : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            var phone = new SamsungS6 { BatteryLife = 999, Height = 199, Weight = 99, Width = 49 };
            return phone;
        }
    }
}
