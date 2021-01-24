using System.Collections.Generic;

namespace task5
{
    class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Customers { get; set; } = new List<User>();
    }
}
