using System;
using System.Reflection;

namespace hw9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            var task1 = new Task1();
            task1.ShowMessage("message");
            task1.ShowNumber(123);

            ///////////////////////////////////////////////////////////////////////////////////////////

            // Task 2

            Type devType = typeof(Developer);            
            AccessLevelAttribute devAttr = (AccessLevelAttribute)devType.GetCustomAttribute(typeof(AccessLevelAttribute), true);

            if (devAttr.AccessLevel == "Develper")
            {
                throw new Exception("Developer does not have access here");
            }

            Type managerType = typeof(Manager);
            AccessLevelAttribute managerAttr = (AccessLevelAttribute)managerType.GetCustomAttribute(typeof(AccessLevelAttribute), true);

            if (managerAttr.AccessLevel == "Manager")
            {
                throw new Exception("Manager does not have access here");
            }

            Type ownerType = typeof(Owner);
            AccessLevelAttribute ownerAttr = (AccessLevelAttribute)ownerType.GetCustomAttribute(typeof(AccessLevelAttribute), true);

            if (managerAttr.AccessLevel == "Owner")
            {
                Console.WriteLine("All Access Available");
            }

        }
    }
}
