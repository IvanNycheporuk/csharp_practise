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
            var numbers = new List<int>();
            var rnd = new Random();

            for (var i = 0; i< 30; i++)
            {
                numbers.Add(rnd.Next(-100, 100));
            }

            foreach(var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var firstPositive = numbers.First(x => x > 0);
            var lastNegative = numbers.Last(x => x < 0);
            

            Console.WriteLine(firstPositive);
            Console.WriteLine(lastNegative);
            Console.ReadKey();
        }
    }
}
