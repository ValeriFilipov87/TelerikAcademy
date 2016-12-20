/* Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/


using System;
using System.Numerics;

class TrailingZeroesInNfaktorial
{
    static void Main()
    {
        long input = UserInput();
        long acc = 5;
        long result = 0;
        result = TrailingZeros(input, acc, result);
        Console.WriteLine(result);

    }

    private static long TrailingZeros(long input, long acc, long r)
    {
        if (input / acc < 1)
        {
            return r;
        }
        else
        {
            return TrailingZeros(input, acc * 5, r + (input / acc));
        }
    }

    private static long UserInput()
    {
        long input = new long();
        bool check = long.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            while (input <= 0)
            {
                Console.WriteLine("The input is wrong!");
                check = long.TryParse(Console.ReadLine(), out input);
            }

        }
        return input;
    }
}

