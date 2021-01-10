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
            var sum = new Calculator((a, b) => { return a + b; });
            var sub = new Calculator((a, b) => { return a - b; });
            var div = new Calculator((a, b) => { 
                if (b == 0)
                {
                    throw new Exception("value cannot be zero");
                }

                return a / b;
            });
            var mul = new Calculator((a, b) => { return a * b; });

            var sumResult = sum.Invoke(1, 2);
            var subResult = sub.Invoke(1, 2);
            var divResult = div.Invoke(1, 2);
            var mulResult = mul.Invoke(1, 2);

            Console.WriteLine($"sum is {sumResult} | sub is {subResult} | div is {divResult} | mul is {mulResult}");

            Console.ReadKey();
        }

        delegate int Calculator(int a, int b);
        
    }
}
