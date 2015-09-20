namespace Builder
{
    using System;
    using System.Collections.Generic;

    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            this.Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "Scooter Feame";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "100cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }
    }
}
