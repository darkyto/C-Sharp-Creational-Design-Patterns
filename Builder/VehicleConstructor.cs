namespace Builder
{
    using System;
    using System.Collections.Generic;

    public class VehicleConstructor
    {
        public void Constructor(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildEngine();
        }
    }
}
