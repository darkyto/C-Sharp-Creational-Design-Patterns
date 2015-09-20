namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AbstractFactory;
    using AbstractFactory.Factories;
    using AbstractFactory.Pizzas;
    using AbstractFactory.Spaghetti;
    using FactoryMethod.Manufacturers;
    using FluentInterface;
    using NUnit.Framework;
    using SimpleFactory;
    using Singelton;
    
    public class NUnitTests
    {
        [Test]
        public void CreateCustomerTest()
        {
            var customer = new Customer();
            customer
                .FirstName("John")
                .LastName("Snow")
                .Gender("Undying")
                .Address("The Wild");

            var actual = "first name: John \nlast name: Snow \ngender: Undying \naddress: The Wild";

            Assert.AreEqual(customer.ToString(), actual);
        }

        [Test]
        public void TestCoffeeFactory()
        {
            var coffePlace = new CoffeeFactory();
            var capuchino = coffePlace.GetCoffee(CoffeType.Cappuccino);

            Assert.AreEqual(capuchino.CoffeeContent, 100);
        }

        [Test]
        public void ManufactureGsm()
        {
            var apple = new Apple();
            var gsm = apple.ManufactureGsm();
            Assert.That(gsm.Start(), Contains.Substring("IPhone 6"));
        }

        [Test]
        public void CretePizzaViaOnlineCompany()
        {
            var alfredo = new AlfreddosPlace();
            var luidji = new LuidjiSpagettiPlace();

            var onlinePizzaPlace = new OnlineDeliveryCompany(alfredo, luidji);
            var peperoni = onlinePizzaPlace.MakePeperoni();
            var carbonara = onlinePizzaPlace.MakeCarbonara();

            Assert.That(peperoni.ToString(), Contains.Substring("Peperoni"));
        }

        [Test]
        public void CreateAlfreddoCalzonePizza()
        {
            var alfredo = new AlfreddosPlace();
            var calzone = alfredo.MakeCalzonePizza();

            Assert.That(calzone.ToString(), Contains.Substring("Calzone made by"));
            Assert.That(calzone.ToString(), Contains.Substring("ham"));
        }

        [Test]
        public void CreateTwoQuateroFormaggiPizza()
        {
            var alfredo = new AlfreddosPlace();
            var quatro = alfredo.MakeQuatroFormaggi();
            var quatro2 = alfredo.MakeQuatroFormaggi();
            Assert.AreEqual(quatro.ToString(), quatro2.ToString());
        }
    }
}
