﻿namespace Singelton
{
    using System;
    using System.Collections.Generic;

    public sealed class Logger
    {
        private static Logger loggerInstance;

        private readonly List<LogEvent> events = new List<LogEvent>();

        private Logger()
        {
        }

        public static Logger Instance
        { 
            get
            {
                if (loggerInstance == null)
                {
                    loggerInstance = new Logger();
                }

                return loggerInstance;
            }
        }

        public void SaveToLog(string message)
        {
            this.events.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            foreach (var ev in this.events)
            {
                Console.WriteLine("Time: {0}, Event: {1}", ev.TimeStamp.ToShortTimeString(), ev.Message);
            }
        }
    }
}
