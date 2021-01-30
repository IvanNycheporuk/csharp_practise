using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("task1");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            GetInfoAboutAllTypes(assembly);

            Console.ReadKey();

            //Type type = assembly.GetType("_task1.CheapTermometr");

            //object instance = Activator.CreateInstance(type);

            //MethodInfo methodShowTemperature = type.GetMethod("ShowTemperature");
            //methodShowTemperature.Invoke(instance, null);

            //MethodInfo methodUser = type.GetMethod("User");
            //object[] parametres = { "Test", 4 };
            //methodUser.Invoke(instance, parametres);

            //Console.ReadKey();
        }

        public static void GetInfoAboutAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 10));
            Console.WriteLine("\nТипы в: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Полное Имя:             {0}", type.FullName);
                Console.WriteLine("Это class:              {0}", type.IsClass);
            }
        }
    }
}
