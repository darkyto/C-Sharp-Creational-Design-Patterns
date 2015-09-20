namespace Builder
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var constructor = new VehicleConstructor();

            var carBuilder = new CarBuilder();
            constructor.Constructor(carBuilder);
            carBuilder.Vehicle.Show();

            var scooterBuilder = new ScooterBuilder();
            constructor.Constructor(scooterBuilder);
            scooterBuilder.Vehicle.Show();
        }
    }
}
