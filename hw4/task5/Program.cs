using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var vocabularyEngToRus = new Dictionary<dynamic, dynamic>();

            vocabularyEngToRus.Add("cat", "кошка1");
            vocabularyEngToRus.Add("dog", "кошка2");
            vocabularyEngToRus.Add("flat", "кошка3");
            vocabularyEngToRus.Add("red", "кошка4");
            vocabularyEngToRus.Add("orange", "кошка5");
            vocabularyEngToRus.Add("water", "кошка6");
            vocabularyEngToRus.Add("bottle", "кошка7");
            vocabularyEngToRus.Add("stone", "кошка8");
            vocabularyEngToRus.Add("day", "кошка9");
            vocabularyEngToRus.Add("date", "кошка10");

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(vocabularyEngToRus["cat"]);
            Console.WriteLine(vocabularyEngToRus["dog"]);
            Console.WriteLine(vocabularyEngToRus["date"]);
            Console.WriteLine(vocabularyEngToRus["stone"]);

            Console.ReadLine();
        }
    }
}
