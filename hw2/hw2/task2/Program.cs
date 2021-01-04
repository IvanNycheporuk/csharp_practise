using System;
using task1;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();

            for (var i = 0; i < 20; i++)
            {
                list.Add(i);
            }            

            var test = list.GetArray();

            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(test[i]);
                //ConsoleWlist.Add(i);
            }

            Console.ReadLine();
        }
    }
}
