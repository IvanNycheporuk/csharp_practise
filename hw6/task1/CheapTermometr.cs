using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class CheapTermometr : Termometr
    {
        public CheapTermometr() { }

        public CheapTermometr(string name, int currentTemperature, int maxTemperature)
            :base(name, currentTemperature, maxTemperature)
        {
        }

        public override void ShowTemperature()
        {
            condition = TermomentCondition.Broken;
            Console.WriteLine("Its is already broken :(");
        }
    }
}
