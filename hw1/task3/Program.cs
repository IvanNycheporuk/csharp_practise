using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator<int, string>();

            var result1 = calculator.Add(1, "123");
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
