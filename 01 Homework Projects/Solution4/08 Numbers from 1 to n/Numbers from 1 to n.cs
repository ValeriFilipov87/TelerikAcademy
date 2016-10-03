/*  Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
    Note: You may need to use a for-loop. */

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Please insert an intiger number:");
        int number;
        bool isParsed = int.TryParse(Console.ReadLine(), out number);
        Console.Clear();
        while (isParsed = !true || number <= 0)
        {
            Console.Clear();
            Console.WriteLine("Wrong input!");
            Console.WriteLine("Please insert positive integer:");
            isParsed = int.TryParse(Console.ReadLine(), out number);
        }
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

