using System.Collections.Generic;

namespace task3
{
    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
