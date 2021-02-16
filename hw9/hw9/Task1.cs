using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9
{
    public class Task1
    {
        [Obsolete("This message is obsolete, DO NOT USE IT", true)]
        public void ShowMessage(string message)
        {
            Console.WriteLine($"message is: {message}");
            Console.ReadLine();
        }
        [Obsolete("This message is not working any more")]
        public void ShowNumber(int number)
        {
            Console.WriteLine($"number is: {number}");
            Console.ReadLine();
        }
    }
}
