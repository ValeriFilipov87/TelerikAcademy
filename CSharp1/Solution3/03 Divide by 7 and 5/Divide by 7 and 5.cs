/* Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time. */

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please input a digit:");
        int digit = int.Parse(Console.ReadLine());
        bool check = digit % 7 == 0 && digit % 5 == 0;
        if (check)
        {
            Console.WriteLine(check);
        }
        else
        {
            Console.WriteLine(check);
        }
    }
}

