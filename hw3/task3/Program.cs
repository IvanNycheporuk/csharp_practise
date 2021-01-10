using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegateList = new List<Calculator>();

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

            delegateList.Add(sum);
            delegateList.Add(sub);
            delegateList.Add(div);
            delegateList.Add(mul);
            delegateList.Add(new Calculator((a, b) => { return a + b * 2; }));

            var getResult = new GetResult((itemsList) => {
                var totalResult = 0;

                foreach(var item in itemsList)
                {
                    totalResult += item.Invoke(2, 6);
                }

                return totalResult / itemsList.Count;
            });

            Console.WriteLine(getResult.Invoke(delegateList));
            Console.ReadKey();
        }

        delegate int Calculator(int a, int b);

        delegate int GetResult(List<Calculator> delegateArrs);
    }
}
