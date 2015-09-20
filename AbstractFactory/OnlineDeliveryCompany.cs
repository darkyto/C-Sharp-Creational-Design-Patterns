namespace AbstractFactory
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory.Factories;
    using AbstractFactory.Pizzas;
    using AbstractFactory.Spaghetti;

    public class OnlineDeliveryCompany
    {
        private readonly PizzaFactory pizzaFactory;
        private readonly SpagettiFactory spagettiFactory;

        public OnlineDeliveryCompany(PizzaFactory pizzaFactory, SpagettiFactory spagettiFactory)
        {
            this.pizzaFactory = pizzaFactory;
            this.spagettiFactory = spagettiFactory;
        }

        public Peperoni MakePeperoni()
        {
            return this.pizzaFactory.MakePeperoni();
        }

        public QuatroFormaggi MakeQuatroFormaggi()
        {
            return this.pizzaFactory.MakeQuatroFormaggi();
        }

        public Carbonara MakeCarbonara()
        {
            return this.spagettiFactory.MakeCarbonara();
        }
    }
}
