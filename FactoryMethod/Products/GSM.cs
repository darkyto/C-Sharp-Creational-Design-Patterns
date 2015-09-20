namespace FactoryMethod.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Gsm
    {
        public int BatteryLife { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string Name { get; set; }

        public abstract string Start();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Phone name: {0}", this.Name);
            sb.AppendLine();
            sb.AppendFormat("Height: {0}", this.Height);
            sb.AppendLine();
            sb.AppendFormat("Width: {0}", this.Width);
            sb.AppendLine();
            sb.AppendFormat("Weight: {0}", this.Weight);
            sb.AppendLine();
            sb.AppendFormat("Battery life: {0}", this.BatteryLife);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
