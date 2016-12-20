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
        int number = int.Parse(Console.ReadLine());
        long a = 0;
        long b = 1;

        for (int i = 0; i < number; i++)
        {
            if (i != 0 && i != number)
            {
                Console.Write(", ");
            }
            long temp = a;
            Console.Write("{0}", a);
            a = b;
            b = temp + b;
        }
        Console.WriteLine();
    }
}

