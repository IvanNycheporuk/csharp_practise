using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            using(DBContextLesson5 db = new DBContextLesson5())
            {
                var company1 = new Company()
                {
                    Name = "Test"
                };

                var user1 = new Customer()
                {
                    Name = "Customer1",
                    Company = company1
                };

                db.Customers.Add(user1);
                db.Companies.Add(company1);

                db.SaveChanges();

                var testCompanies = db.Companies.ToList();

                foreach(var item in testCompanies)
                {
                    Console.WriteLine(item.Name + " " + item.Id );                    
                }

                var testCustomers = db.Customers.ToList();
                foreach (var item in testCustomers)
                {
                    Console.WriteLine(item.Name + " " + item.Id);
                }

                Console.ReadLine();
            }
        }
    }
}
