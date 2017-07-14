using System;


namespace Problem_1.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(inputYear,1,1);
            bool IsLeapYear = DateTime.IsLeapYear(date.Year);
            if (IsLeapYear)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
