/*  Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive */

using System;

class PrimeNumberCheck
{
    static void Main()
    {

        int digit = int.Parse(Console.ReadLine());

        bool prime = false;
        for (int i = 2; i <= Math.Sqrt(digit); i++)
        {
            if (digit % i == 0)
            {
                prime = true;
                break;
            }
        }
        if (prime || digit < 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}

