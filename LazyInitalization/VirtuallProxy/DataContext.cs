namespace LazyInitalization.VirtuallProxy
{
    public class DataContext
    {
        public User GetUserById(int id)
        {
            return new UserProxy
            {
                Id = id,
            };
        }
    }
}
