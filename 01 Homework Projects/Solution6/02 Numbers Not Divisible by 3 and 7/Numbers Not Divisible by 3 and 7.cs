/*  Problem 2. Numbers Not Divisible by 3 and 7

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 or 7, on a single line, separated by a space.
*/

using System;

class NumbersNotDivisibleByThreeaAndSeven
{
    static void Main()
    {
        int input = UserInput();
        
        for (int i = 0; i <= input; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
    private static int UserInput()
    {
        int input = new int();
        Console.WriteLine("Please input intiger number!");
        bool check = int.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong! Please input intiger number!");
            check = int.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}

