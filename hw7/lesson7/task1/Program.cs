using System;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo task1Folder = new DirectoryInfo(@"C:\task1");

            if (!task1Folder.Exists)
            {
                task1Folder.Create();
            } else
            {
                Console.WriteLine("Folder already exists");
            }

            for (var i = 0; i <= 50; i++)
            {
                string folderPath = @"C:\task1\Folder_" + i;
                DirectoryInfo folder = new DirectoryInfo(folderPath);
                folder.Create();
            }

            for (var i = 0; i <= 50; i++)
            {
                string dirName = @"C:\task1\Folder_" + i;

                DirectoryInfo dirInfo = new DirectoryInfo(dirName);

                Console.WriteLine($"Название каталога: {dirInfo.Name}");
                Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
                Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
                Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            }

            for (var i = 0; i <= 50; i++)
            {
                string dirName = @"C:\task1\Folder_" + i;

                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                    dirInfo.Delete(true);
                    Console.WriteLine("Catalog has been deleted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
