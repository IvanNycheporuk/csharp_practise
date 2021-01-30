using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);

                // string[] files = Directory.GetFiles(drive.Name, "test.txt", SearchOption.AllDirectories); didnt work due the access issues

                var file = Directory.GetFiles(@"C:\task2", "task2.txt", SearchOption.AllDirectories);

                FileStream fstream = File.OpenRead(file[0]);                
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                
                string textFromFile = Encoding.Default.GetString(array);
                Console.WriteLine($"Text from file: {textFromFile}");

                FileStream destination = File.Create(@"C:\task2\archive.zip");
                GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);
                int theByte = fstream.ReadByte();
                while (theByte != -1)
                {
                    compressor.WriteByte((byte)theByte);
                    theByte = fstream.ReadByte();
                }

                compressor.Close();
            }

            Console.ReadLine();

            //
        }
    }
}
