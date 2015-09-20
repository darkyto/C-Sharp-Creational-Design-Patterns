namespace AbstractFactory.Pizzas
{
    using System;
    using System.Collections.Generic;

    public class Peperoni : Pizza
    {
        private readonly string madeBy;

        public Peperoni(IEnumerable<string> ingredients, string madeBy)
            : base(ingredients)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get
            {
                return string.Format("Peperoni made by {0}", this.madeBy);
            }
        }
    }
}
