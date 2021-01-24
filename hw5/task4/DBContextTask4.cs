using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class DBContextTask4 : DbContext
    {
        public DBContextTask4()
            : base("DbConnection")
        {}

        public DbSet<Car> Car { get; set; }
        public DbSet<CarManufacter> CarManufacters { get; set; }
        public DbSet<CarMarket> CarMarkets { get; set; }        
    }
}
