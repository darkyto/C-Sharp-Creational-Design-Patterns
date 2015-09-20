namespace FactoryMethod.Manufacturers
{
    using System;
    using System.Collections.Generic;
    using FactoryMethod.Products;

    public abstract class Manufacturer
    {
        public abstract Gsm ManufactureGsm();
    }
}
