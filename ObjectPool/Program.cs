namespace ObjectPool
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Program
    {
        public static void Main(string[] args)
        {
            var warehouse = new Warehouse<Equipment>();

            var equipment1 = warehouse.GetEquipmnet();
            equipment1.EmployeeName = "Atos";
            Console.WriteLine(
                "Equipment 1 ordered on {0:MM/dd/yyyy hh:mm:ss.fff tt} used by {1}",
                equipment1.OrderedAt,
                equipment1.EmployeeName);
            Thread.Sleep(2000);

            var equipment2 = warehouse.GetEquipmnet();
            equipment1.EmployeeName = "Portos";
            Console.WriteLine(
                "Equipment 2 ordered on {0:MM/dd/yyyy hh:mm:ss.fff tt} used by {1}",
                equipment2.OrderedAt,
                equipment1.EmployeeName);
            Thread.Sleep(2000);

            warehouse.ReleaseEquipment(equipment1);

            var equipment3 = warehouse.GetEquipmnet();
            equipment1.EmployeeName = "Aramis";
            Console.WriteLine(
                "Equipment 3 ordered on {0:MM/dd/yyyy hh:mm:ss.fff tt} used by {1}",
                equipment3.OrderedAt,
                equipment1.EmployeeName);
            Thread.Sleep(2000);
        }
    }
}
