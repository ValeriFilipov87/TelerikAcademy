/*  Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
*/

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Input a: ");
        long a = UserInput();
        Console.Write("Input b: ");
        long b = UserInput();
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

    private static long UserInput()
    {
        long input = new long();
        bool check = long.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong!");
            check = long.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}

