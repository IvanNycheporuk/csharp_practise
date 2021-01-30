using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo task1Folder = new DirectoryInfo(@"C:\task2");

            if (!task1Folder.Exists)
            {
                task1Folder.Create();
            }
            else
            {
                Console.WriteLine("Folder already exists");
            }

            string task2FilePath = @"C:\task2\task2.txt";

            FileStream task2File = new FileStream(task2FilePath, FileMode.OpenOrCreate);            

            Console.WriteLine("Please enter some data to write into file:");
            string text = Console.ReadLine();

            StreamWriter streamWriter = new StreamWriter(task2File);

            streamWriter.WriteLine(text);

            streamWriter.Close();
            task2File.Close();

            //FileStream fileStream = File.Open(task2FilePath, FileMode.OpenOrCreate);

            //StreamReader streamReader = new StreamReader(fileStream);
            StreamReader streamReader = new StreamReader(task2FilePath);

            Console.WriteLine(streamReader.ReadToEnd());
            Console.ReadLine();

            streamReader.Close();
            // fileStream.Close();
        }
    }
}
