using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10y
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input year of birth");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime Date = DateTime.Now;
            TimeSpan difference = Date - birthDate;
            int days = (int)difference.TotalDays;
            Console.WriteLine("Your Age is:" + days/365);
            Console.WriteLine("In 10 years, you will be:" + (days / 365 + 10));

        }
    }
}
