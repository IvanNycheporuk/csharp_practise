namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Calculator.Add(1, 2);
            var sub = Calculator.Sub(1, 2);
            var multiple = Calculator.Multiple(1, 2);
            var divide = Calculator.Divide(1, 2);
        }
    }

    class Calculator
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public static dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }
        public static dynamic Multiple(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            return a / b;
        }
    }
}
