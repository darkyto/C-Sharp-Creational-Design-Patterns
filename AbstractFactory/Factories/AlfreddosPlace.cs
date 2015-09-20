namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory.Pizzas;

    public class AlfreddosPlace : PizzaFactory
    {
        private const string NAME = "Alfreddo's pizza place";

        public override Calzone MakeCalzonePizza()
        {
            var ingredients = new List<string> { "tomatoes", "ham", "bacon" };
            var pizza = new Calzone(ingredients, NAME);
            return pizza;
        }

        public override QuatroFormaggi MakeQuatroFormaggi()
        {
            var ingredients = new List<string> { "cheese", "blue cheese", "yellow cheese", "smoked cheese" };
            var pizza = new QuatroFormaggi(ingredients, NAME);
            return pizza;
        }

        public override Peperoni MakePeperoni()
        {
            var ingredients = new List<string> { "cheese", "peppers", "bacon", "rigan" };
            var pizza = new Peperoni(ingredients, NAME);
            return pizza;
        }
    }
}
