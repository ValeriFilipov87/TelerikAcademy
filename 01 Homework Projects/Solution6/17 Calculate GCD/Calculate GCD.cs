/*  Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
*/

using System;

class CalculateGCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] digits = input.Split(' ');

        long a = long.Parse(digits[0]);
        long b = long.Parse(digits[1]);
        long result = GCD(a, b);
        Console.WriteLine(result);

    }

    private static long GCD(long a, long b)
    {
        if (a % b == 0)
        {
            return b;
        }
        else
        {
            return GCD(b, a % b);
        }
    }   
}

