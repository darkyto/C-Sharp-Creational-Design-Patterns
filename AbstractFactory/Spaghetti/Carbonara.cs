namespace AbstractFactory.Spaghetti
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Carbonara : Spagetti
    {
        private readonly string madeBy;

        public Carbonara(IEnumerable<string> ingredients, string madeBy)
            : base(ingredients)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get 
            { 
                return string.Format("Carbonara made by {0}", this.madeBy); 
            }
        }
    }
}
