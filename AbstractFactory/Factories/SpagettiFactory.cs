namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory.Spaghetti;

    public abstract class SpagettiFactory
    {
        public abstract Carbonara MakeCarbonara();
    }
}
