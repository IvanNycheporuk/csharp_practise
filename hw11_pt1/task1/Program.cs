using System;
using System.Threading;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart recursion = new ParameterizedThreadStart(Recursion);
            Thread thread = new Thread(recursion);

            thread.Start(10);

            Console.ReadKey();
        }

        static void Recursion(object bjNumber)
        {
            if ((int)bjNumber != 0)
            {
                ParameterizedThreadStart recursion = new ParameterizedThreadStart(Recursion);
                Thread thread = new Thread(recursion);

                var number = Convert.ToInt32(bjNumber);
                number--;

                Console.WriteLine(bjNumber);    
                
                thread.Start(number);
            }
        }
    }
}
