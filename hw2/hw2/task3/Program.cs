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
            var test = new SortedList<string, int>();
            test.Add("test", 11);
            test.Add("abc", 92);
            test.Add("decimal", 31);
            test.Add("draw", 48);
            test.Add("english", 75);
            test.Add("movies", 16);
            test.Add("asdqwe", 37);
            test.Add("zerro", 28);
            test.Add("pork", 91);
            test.Add("bimba", 10);

            for (var i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test.Keys[i] + " " + test.Values[i]);
            }

            Console.WriteLine("-", 10);

            for (var i = test.Count-1; i > 0; i--)
            {
                Console.WriteLine(test.Keys[i] + " " + test.Values[i]);
            }

            Console.ReadKey();
        }
    }
}
