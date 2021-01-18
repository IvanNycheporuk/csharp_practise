using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Customer
    {
        public int ClientId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int LessonDuration { get; set; }

        public override string ToString()
        {
            return $"Lesson duration: {ClientId}, Year: {Year}, Month: {Month}";
        }
    }
}
