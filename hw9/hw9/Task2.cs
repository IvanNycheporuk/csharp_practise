using System;

namespace hw9
{
    class Task2
    {
    }
    [AccessLevel("Manager")]
    class Manager
    {
        public void ShowManage()
        {
            Console.WriteLine("Manager message");
        }
    }

    [AccessLevel("Developer")]
    class Developer
    {
        public void ShowDeveloper()
        {
            Console.WriteLine("Developer message");
        }
    }

    [AccessLevel("Owner")]
    class Owner
    {
        public void ShowOwner()
        {
            Console.WriteLine("Owner message");
        }
    }
}
