using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            var fitnessClients = new List<Customer>();

            fitnessClients.Add(new Customer()
            {
                ClientId = 1,
                Month = 6,
                Year = 2020,
                LessonDuration = 12
            });

            fitnessClients.Add(new Customer()
            {
                ClientId = 2,
                Month = 7,
                Year = 2019,
                LessonDuration = 12
            });

            fitnessClients.Add(new Customer()
            {
                ClientId = 3,
                Month = 4,
                Year = 2019,
                LessonDuration = 30
            });

            fitnessClients.Add(new Customer
            {
                ClientId = 4,
                Month = 1,
                Year = 2021,
                LessonDuration = 40
            });

            var targetClient = fitnessClients
                .Where(x => x.LessonDuration == fitnessClients.Min(y => y.LessonDuration))
                .LastOrDefault();

            Console.WriteLine(targetClient.ToString());
            Console.ReadKey();
        }
    }
}
