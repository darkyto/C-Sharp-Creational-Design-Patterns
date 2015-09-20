namespace ObjectPool
{
    using System;
    using System.Collections.Generic;

    public class Equipment : IDisposable
    {
        private readonly DateTime orderedAt = DateTime.Now;

        public DateTime OrderedAt
        {
            get { return this.orderedAt; }
        }

        public string EmployeeName { get; set; }

        public void Dispose()
        {
            this.EmployeeName = null;
        }
    }
}
