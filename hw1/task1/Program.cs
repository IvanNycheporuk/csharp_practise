using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book<decimal>();

            book.BookName = "Test";
            book.BookPrice = 123;

            book.ShowBook();
        }
    }
}
