using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarMarket> CarMarkets { get; set; } = new List<CarMarket>();
        public List<CarManufacter> CarManufactures { get; set; } = new List<CarManufacter>();
    }
}
