using Interfaces;
using System;

namespace task1
{
    public abstract class Termometr : ITermometr
    {
        protected string name;
        protected int currentTemperature;
        protected int maxTemperature;
        protected TermomentCondition condition;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public int MaxTemperature
        {
            get { return maxTemperature; }
        }

        public TermomentCondition TermomentCondition { 
            get { return condition; }
        }

        protected Termometr()
        {
            condition = TermomentCondition.Used;
        }

        protected Termometr(string name, int currentTemperature, int maxTemperature)
            :this()
        {
            this.name = name;
            this.currentTemperature = currentTemperature;
            this.maxTemperature = maxTemperature;
        }

        public abstract void ShowTemperature();

        public void User(string name, int age)
        {
            Console.WriteLine($"The name is { name } and the device age is: { age }");
        }
    }
}
