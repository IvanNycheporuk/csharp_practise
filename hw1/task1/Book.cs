using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Book<T>
    {          
        private string Name;
        private T Price;

        public string BookName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public T BookPrice
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        public void ShowBook()
        {
            Console.WriteLine("The price is: " + Price + " and Book name is: " + Name);
        }
    }
}
