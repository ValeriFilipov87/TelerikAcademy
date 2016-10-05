/*  Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
    Note: You may need to learn how to use loops. 
    Examples:

    n	comments
    1	0
    3	0 1 1
    10	0 1 1 2 3 5 8 13 21 34 */


using System;

class FibonacciNumbers
{
    static void Main()
    {
        int number;
        long a = 0;
        long b = 1;

        Console.WriteLine("Please insert an intiger number:");
        bool isParsed = int.TryParse(Console.ReadLine(), out number);

        Console.Clear();

        while (isParsed = !true || number <= 0)
        {
            Console.Clear();
            Console.WriteLine("Wrong input!");
            Console.WriteLine("Please insert positive integer:");
            isParsed = int.TryParse(Console.ReadLine(), out number);
        }

        for (int i = 0; i < number; i++)
        {
            long temp = a;
            Console.Write("{0}, ", a);
            a = b;
            b = temp + b;

        }
        Console.WriteLine();
    }
}

