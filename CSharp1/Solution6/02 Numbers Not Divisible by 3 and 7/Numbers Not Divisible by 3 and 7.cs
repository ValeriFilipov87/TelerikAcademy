﻿/*  Problem 2. Numbers Not Divisible by 3 and 7

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 or 7, on a single line, separated by a space.
*/

using System;

class NumbersNotDivisibleByThreeaAndSeven
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i <= input; i++)
        {
            
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i);
                if (i != 0 && i != input + 1)
                {
                    Console.Write(' ');
                }
            }
        }
        Console.WriteLine();
    }

}

