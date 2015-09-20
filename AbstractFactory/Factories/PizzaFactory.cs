namespace AbstractFactory.Factories
{
    using AbstractFactory.Pizzas;

    public abstract class PizzaFactory
    {
        public abstract Calzone MakeCalzonePizza();

        public abstract QuatroFormaggi MakeQuatroFormaggi();

        public abstract Peperoni MakePeperoni();
    }
}
