using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task3_Reflector
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("task1");
                Console.WriteLine("task1 has been successfully loaded");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            GetInfoAboutAllTypes(assembly);

            GetInfoAboutAllMembers(assembly);

            GetMethodsParams(assembly);

            Console.ReadKey();
        }

        public static void GetInfoAboutAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 10));
            Console.WriteLine($"\nTypes in {assembly.FullName} \n");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine($"Full name:  {type.FullName}" );
                Console.WriteLine($"is it class:  {type.IsClass}" );
            }
        }


        public static void GetInfoAboutAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 10));

            Type type = assembly.GetType("_006_Car_Library.SportsCar");

            Console.WriteLine("\nЧлены класса: {0} \n", type.Name);

            MemberInfo[] membersInfo = type.GetMembers();

            foreach (MemberInfo memberInfo in membersInfo)
            {
                Console.WriteLine("{0,-15}:  {1}", memberInfo.MemberType, memberInfo);
            }
        }

        public static void GetMethodsParams(Assembly assembly)
        {
            Type type = assembly.GetType("task1.CheapTermometr");

            MethodInfo method = type.GetMethod("Driver"); // Equals , Acceleration, Driver

            // Вывод информации о количестве параметров.
            Console.WriteLine("\nИнформация о параметрах для метода {0}", method.Name);

            ParameterInfo[] parameters = method.GetParameters();
            Console.WriteLine("Method has " + parameters.Length + " parametrs");

            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine($"Param name: { parameter.Name }" );
                Console.WriteLine($"Position in method: { parameter.Position }");
                Console.WriteLine($"Param type: {parameter.ParameterType}");
            }
        }
    }
}
