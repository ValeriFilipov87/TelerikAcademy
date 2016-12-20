/*  A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
    a minute in range [00…59] and AM / PM designator) 
    and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 

    Note: You may need to learn how to parse dates and times.*/


using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Input digit for hour between 1 and 12");
        int inputHour = IntUserInputHour();
        Console.WriteLine("Input digit for minutes between 0 and 59");
        int inputMinute = IntUserIinputMinute();
        Console.WriteLine("Input AM or PM");
        string designator = Console.ReadLine();

        string stringHour = Convert.ToString(inputHour);
        string stringMinute = Convert.ToString(inputMinute);
        string time = stringHour + ":" + stringMinute + " " + designator;

        DateTime t = Convert.ToDateTime(time);
        DateTime beginning = Convert.ToDateTime("1:00 PM");
        DateTime ending = Convert.ToDateTime("3:00 AM");
        ending = ending.AddDays(1);

        if (designator == "AM" || designator == "am")
        {
            t = t.AddDays(1);
        }

        if (beginning <= t && t < ending)
        {
            Console.WriteLine("Beer Time!!!!");
        }
        else
        {
            Console.WriteLine("Non-beer time :(");
        }
    }

    private static int IntUserIinputMinute()
    {
        int input = new int();
        bool check;
        check = int.TryParse(Console.ReadLine(), out input);
        if (input < 0 || input > 59)
        {
            check = false;

            while (!check)
            {
                Console.WriteLine("Wrong input! Please input an intiger digit between 0 and 59");
                check = int.TryParse(Console.ReadLine(), out input);
                if (input < 0 || input > 59)
                {
                    check = false;
                }
            }
        }
        return input;
    }

    private static int IntUserInputHour()
    {
        int input = new int();
        bool check;
        check = int.TryParse(Console.ReadLine(), out input);
        if (input < 1 || input > 12)
        {
            check = false;

            while (!check)
            {
                Console.WriteLine("Wrong input! Please input an intiger digit between 1 and 12");
                check = int.TryParse(Console.ReadLine(), out input);
                if (input < 1 || input > 12)
                {
                    check = false;
                }
            }
        }
        return input;
    }

}

