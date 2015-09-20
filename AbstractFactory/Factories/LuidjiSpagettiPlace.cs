namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory.Spaghetti;

    public class LuidjiSpagettiPlace : SpagettiFactory
    {
        private const string NAME = "Luidji Spagetti Place";

        public override Carbonara MakeCarbonara()
        {
            var ingredients = new List<string> { "cheese", "onion", "bacon" };
            var spaget = new Carbonara(ingredients, NAME);
            return spaget;
        }
    }
}
