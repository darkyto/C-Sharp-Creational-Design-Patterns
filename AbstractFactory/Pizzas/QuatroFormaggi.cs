namespace AbstractFactory.Pizzas
{
    using System;
    using System.Collections.Generic;

    public class QuatroFormaggi : Pizza
    {
        private readonly string madeBy;

        public QuatroFormaggi(IEnumerable<string> ingredients, string madeBy)
            : base(ingredients)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get 
            { 
                return string.Format("Quatro Formaggi made by {0}", this.madeBy);
            }
        }     
    }
}
