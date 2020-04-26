using System.Data.Entity;

namespace entity
{
    public class UserContext:DbContext
    {
        public UserContext() : base("connectionString")
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}