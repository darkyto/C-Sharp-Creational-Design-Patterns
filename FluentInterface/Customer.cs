namespace FluentInterface
{
    using System;

    public class Customer
    {
        private readonly CustomerContext customerContext = new CustomerContext();

        public Customer FirstName(string firstName)
        {
            this.customerContext.FirstName = firstName;
            return this;
        }

        public Customer LastName(string lastName)
        {
            this.customerContext.LastName = lastName;
            return this;
        }

        public Customer Gender(string gender)
        {
            this.customerContext.Gender = gender;
            return this;
        }

        public Customer Address(string address)
        {
            this.customerContext.Address = address;
            return this;
        }

        public override string ToString()
        {
            return string.Format(
                "first name: {0} \nlast name: {1} \ngender: {2} \naddress: {3}", 
                this.customerContext.FirstName, 
                this.customerContext.LastName, 
                this.customerContext.Gender, 
                this.customerContext.Address);
        }
    }
}
