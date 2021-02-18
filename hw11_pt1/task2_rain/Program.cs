using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2_rain
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();
            var density = 10; // (10% of each line will be a matrix character)
            var speed = MatrixCodeSpeed.Normal;

            // Hide the cursor - set this to 'true' again before accepting user input
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            while (true)
            {
                // Once the lines count is greater than the window height,
                // remove the first item, so that the list "scrolls" also
                if (lines.Count >= Console.WindowHeight)
                {
                    lines.Remove(lines[0]);
                }

                // Add a new random line to the list, which will be the new topmost line.
                lines.Add(GetMatrixLine(density));
                Console.SetCursorPosition(0, 0);

                // Print the lines out to the console in reverse order so the
                // first line is always last, or on the bottom of the window
                for (int i = lines.Count - 1; i >= 0; i--)
                {
                    Console.Write(lines[i]);
                }

                Thread.Sleep(TimeSpan.FromMilliseconds((int)speed));
            }        
    }
        enum MatrixCodeSpeed
        {
            Fastest = 0,
            Faster = 33,
            Fast = 67,
            Normal = 100,
            Slow = 333,
            Slower = 667,
            Slowest = 1000
        }

        private static Random rnd = new Random();

        // Add whatever 'matrix' characters you want to this array. If you prefer to have one 
        // character chosen more often than the others, you can write code to favor a specific
        // index, or just add more instances of that character to the array below:

        private static char[] matrixChars = new[] { '1', '2', '3', '4' };

        static string GetMatrixLine(int density)
        {
            var line = new StringBuilder();

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                // Choose a random number from 0-99 and see if it's greater than density
                line.Append(rnd.Next(100) > density
                    ? ' '  // If it is, add a space to reduce line density
                    : matrixChars[rnd.Next(matrixChars.Length)]); // Pick a random character
            }

            return line.ToString();
        }
    }
}
