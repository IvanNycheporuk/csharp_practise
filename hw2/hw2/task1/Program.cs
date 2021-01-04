using System;

namespace task1
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

            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(list[i]);                
            }
            
            Console.ReadLine();
        }
    }
}
