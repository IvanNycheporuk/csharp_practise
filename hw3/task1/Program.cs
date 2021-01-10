using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        delegate int Sum(int a, int b, int c);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Sum sum = new Sum((a,b,c) =>
            {
                return (a + b + c) / 3;
            });

            var result = sum.Invoke(1,2,3);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
