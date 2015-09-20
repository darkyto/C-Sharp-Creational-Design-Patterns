namespace FluentInterface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var customer = new Customer();
            customer
                .FirstName("John")
                .LastName("Snow")
                .Gender("Undying")
                .Address("The Wild");
            Console.WriteLine(customer.ToString());

            Console.WriteLine(new string('-', 60));

            var customerTwo = new Customer();
            customerTwo
                .FirstName("Maria")
                .Gender("Female");
            Console.WriteLine(customerTwo.ToString());

            Console.WriteLine(new string('-', 60));

            var customer2 = new Customer();
            customer2
                .FirstName("John2")
                .LastName("Snow2")
                .Gender("Undying2")
                .Address("The Wild2");

            var all = new List<Customer>() { customer2, customer };

            Console.WriteLine(all[0].ToString());
        }
    }
}
