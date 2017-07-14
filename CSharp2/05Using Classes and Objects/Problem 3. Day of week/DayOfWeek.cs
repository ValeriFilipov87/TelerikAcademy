using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Day_of_week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime currentDay = DateTime.Now;
            Console.WriteLine(currentDay.DayOfWeek);
        }
    }
}
