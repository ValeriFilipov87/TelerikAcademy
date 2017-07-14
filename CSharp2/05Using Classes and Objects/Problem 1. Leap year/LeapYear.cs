using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(inputYear,1,1);
            bool IsLeapYear = DateTime.IsLeapYear(date.Year);
            Console.WriteLine(IsLeapYear);
        }
    }
}
