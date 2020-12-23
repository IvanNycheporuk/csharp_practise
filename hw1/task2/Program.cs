using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MyClass<Program>();

            var test2 = test.FactoryMethod();

            Console.WriteLine(test2);

            Console.ReadKey();
        }
    }
}
