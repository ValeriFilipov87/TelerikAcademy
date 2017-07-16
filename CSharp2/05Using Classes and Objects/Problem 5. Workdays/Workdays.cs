using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Workdays
{
    class Workdays
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now.Date;
            Console.WriteLine(today.ToShortDateString());

            string stringInputDate = Console.ReadLine();
            string[] values = stringInputDate.Split('/', '.');
            int[] dates = Array.ConvertAll<string, int>(values, int.Parse);
            DateTime inputDate = new DateTime(dates[2], dates[1], dates[0]);
            Console.WriteLine(inputDate.ToShortDateString());

            int countOfWorkingDays = new int();
            int check = DateTime.Compare(today, inputDate);

            string[] holidays = { "Saturday", "Sunday", "25/07/2017" };

            bool skip = false;

            while (check < 0)
            {
                today = today.AddDays(1);
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today.DayOfWeek.ToString() == holidays[i] || today.ToShortDateString() == holidays[i])
                    {
                        skip = true;
                    }
                }

                if (skip)
                {
                    skip = false;
                    continue;
                }

                countOfWorkingDays++;
                check = DateTime.Compare(today, inputDate);
            }
            Console.WriteLine(countOfWorkingDays - 1);
        }
    }
}
