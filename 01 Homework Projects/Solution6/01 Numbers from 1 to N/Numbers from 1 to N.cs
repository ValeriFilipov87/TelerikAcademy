/*  Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
*/

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            if (i != 1 && i != input+1)
            {
                Console.Write(' ');
            }
            Console.Write(i);
        }
        Console.WriteLine();
    }
}

