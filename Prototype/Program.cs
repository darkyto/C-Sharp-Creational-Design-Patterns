namespace Prototype
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var darkTrooper = new StormTrooper("Dark trooper", 180, 80);
            Console.WriteLine(darkTrooper);
            Console.WriteLine();

            // var anotherDarkTrooper = new Stormtrooper("Dark trooper", 180, 80);
            var anotherDarkTrooper = darkTrooper.Clone();
            darkTrooper.Height = 200;
            Console.WriteLine("Deep clone - darkTrooper is now with 200 hp");
            Console.WriteLine(darkTrooper);
            Console.WriteLine(anotherDarkTrooper);
        }
    }
}
