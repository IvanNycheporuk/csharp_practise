using System.Data.Entity;

namespace task5
{
    class DbContextTask5 : DbContext
    {
        public DbContextTask5()
            : base("DBConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
