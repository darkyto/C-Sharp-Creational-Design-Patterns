namespace LazyInitalization.VirtuallProxy
{
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }

        public virtual List<string> Roles { get; set; }
    }
}
