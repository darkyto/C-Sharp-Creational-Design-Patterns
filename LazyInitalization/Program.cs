namespace LazyInitalization
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using LazyInitalization.VirtuallProxy;

    public class Program
    {
        public static void Main()
        {
            var lazyFactoryObject = new LazyFactoryObject();
            var list = lazyFactoryObject.GetLazyFactoryObject(LazyObjectType.Medium);
            Console.WriteLine(list.Result.Count);

            Console.WriteLine(new string('-', 60));

            var lazyInit = new Lazy<StreamReader>(() => new StreamReader("LazyInitialization.exe.config"));
            if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                var result = lazyInit.Value.ReadToEnd();
                Console.WriteLine(result);
            }

            Console.WriteLine(new string('-', 60));
            var db = new DataContext();
            var user = db.GetUserById(337);
            Console.WriteLine(user.Roles.Count);
        }
    }
}
