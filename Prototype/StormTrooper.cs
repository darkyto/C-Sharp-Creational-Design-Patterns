namespace Prototype
{
    using System;
    using System.Collections.Generic;

    public class StormTrooper : StormTrooperPrototype
    {
        public StormTrooper(string type, int height, int weight)
        {
            this.Type = type;
            this.Height = height;
            this.Weight = weight;
        }

        public string Type { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public override StormTrooper Clone()
        {
            return this.MemberwiseClone() as StormTrooper;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Height: {1}, Weight: {2}", this.Type, this.Height, this.Weight);
        }
    }
}
