using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            using(DbContextTask5 db = new DbContextTask5())
            {
                //var copmany1 = new Application() { Name = "TEstCompany1" };
                //var copmany2 = new Application() { Name = "TEstCompany2" };
                //var copmany3 = new Application() { Name = "TEstCompany3" };
                //var copmany4 = new Application() { Name = "TEstCompany4" };

                //var customer1 = new User() { Name = "customer1", Age = 31 };
                //var customer2 = new User() { Name = "customer2", Age = 23 };
                //var customer3 = new User() { Name = "customer3", Age = 22 };
                //var customer4 = new User() { Name = "customer4", Age = 33 };

                //copmany1.Customers.Add(customer1);
                //copmany1.Customers.Add(customer2);
                //copmany2.Customers.Add(customer3);
                //copmany2.Customers.Add(customer4);
                //copmany3.Customers.Add(customer1);
                //copmany3.Customers.Add(customer2);
                //copmany4.Customers.Add(customer3);
                //copmany4.Customers.Add(customer4);

                //db.Users.Add(customer1);
                //db.Users.Add(customer2);
                //db.Users.Add(customer3);
                //db.Users.Add(customer4);

                //db.SaveChanges();

                var user = db.Users.FirstOrDefault();
                Console.WriteLine(user.Name + " " + user.Id);

                var orderedUser = db.Users.OrderBy(x => x.Age).First();
                Console.WriteLine(orderedUser.Name + " " + orderedUser.Id);

                var averageAge = db.Users.Average(x => x.Age);
                Console.WriteLine(averageAge);

                var minAge = db.Users.Min(x => x.Age);
                Console.WriteLine(minAge);

                var usersCount = db.Users.Count();
                Console.WriteLine(usersCount);                

                // Task6 solution

                db.Users.Include("Company");

                var userTest = db.Users.Find(3);
                Console.WriteLine(userTest.Id);

                var userAge = db.Users.ToList().Find(x => x.Age == 22);
                Console.WriteLine(userAge.Age);

                var names = db.Users.Select(x => x.Name).ToList();

                foreach(var item in names)
                {
                    Console.WriteLine(item);
                }

                Console.ReadLine();

            }
        }
    }
}
