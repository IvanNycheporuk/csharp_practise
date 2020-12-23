using System;

namespace task3
{
    class Calculator<T1, T2>
    {
        public double Add(T1 param1, T2 param2)
        {
            return Convert.ToDouble(param1) + Convert.ToDouble(param2);
        }

        public double Substract(T1 param1, T2 param2)
        {
            return Convert.ToDouble(param1) - Convert.ToDouble(param2);
        }

        public double Multiply(T1 param1, T2 param2)
        {
            return Convert.ToDouble(param1) * Convert.ToDouble(param2);
        }

        public double Devide(T1 param1, T2 param2)
        {
            return Convert.ToDouble(param1) / Convert.ToDouble(param2);
        }
    }
}
