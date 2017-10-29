using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inputFirstDate = Convert.ToDateTime(Console.ReadLine());
            DateTime inputSecondDate = Convert.ToDateTime(Console.ReadLine());

            int result = (inputSecondDate - inputFirstDate).Days;
            Console.WriteLine(result);
        }
    }
}
