using System;
using System.Collections.Generic;

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

            var newDictionary = new Dictionary<int, string>();

            newDictionary.Add(1, "A");
            newDictionary.Add(2100, "A");
            newDictionary.Add(322, "A");
            newDictionary.Add(111, "A");
            newDictionary.Add(131, "A");
            newDictionary.Add(231, "A");
            newDictionary.Add(5631, "A");
            newDictionary.Add(7109, "A");

            foreach(var item in newDictionary)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
