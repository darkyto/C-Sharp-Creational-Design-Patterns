namespace FactoryMethod.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SamsungS6 : Gsm
    {
        public SamsungS6()
        {
            this.Name = "Samsung S6";
        }

        public override string Start()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Samsung S6 loading..");
            sb.AppendLine("HELLO! I am your Samsung S6!");
            return sb.ToString();
        }
    }
}
