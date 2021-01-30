using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ExpensiveTermometr : Termometr
    {
        public ExpensiveTermometr() { }

        public ExpensiveTermometr(string name, int currentTemperature, int maxTemperature)
            : base(name, currentTemperature, maxTemperature)
        {
        }

        public override void ShowTemperature()
        {
            Console.WriteLine("Its working fine :)");
        }
    }
}
