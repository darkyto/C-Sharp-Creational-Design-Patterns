namespace Singelton
{
    using System;

    public class LogEvent
    {
        public LogEvent(string message)
        {
            this.Message = message;
            this.TimeStamp = DateTime.Now;
        }

        public string Message { get; private set; }

        public DateTime TimeStamp { get; private set; }
    }
}
