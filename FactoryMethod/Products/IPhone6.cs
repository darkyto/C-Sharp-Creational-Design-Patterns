namespace FactoryMethod.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class IPhone6 : Gsm
    {
        public IPhone6()
        {
            this.Name = "IPhone 6";
        }

        public override string Start()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Apple IPhone 6 loading..");
            sb.AppendLine("Hi! I Am APPLE IPhone 6!");
            return sb.ToString();
        }
    }
}
