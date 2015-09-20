namespace Singelton
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var logger = Logger.Instance;
            logger.SaveToLog("I am drinking Jim Beam");
            logger.SaveToLog("Vodka Absolut Rullz Yo");
            logger.PrintLog();

            var logger2 = Logger.Instance;
            logger2.SaveToLog("Coca Cola Sucks");

            // now because we have only ONE instance this will write into our first logger and not in new logger2 (logger two is reference to logger)
            logger.PrintLog();
        }
    }
}
