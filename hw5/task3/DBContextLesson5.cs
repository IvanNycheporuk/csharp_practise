using System.Data.Entity;

namespace task3
{
    class DBContextLesson5 : DbContext
    {
        public DBContextLesson5()
           : base("DbConnection")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
