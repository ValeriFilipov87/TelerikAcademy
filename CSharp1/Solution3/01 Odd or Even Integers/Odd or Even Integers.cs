/* Write an expression that checks if given integer is odd or even. */


using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please input a digit:");
        int digit = int.Parse(Console.ReadLine());
        int result = digit % 2;
        if (result == 0)
        {
            Console.WriteLine("The digit is even");
        }
        else
        {
            Console.WriteLine("The digit is odd");
        }
    }
}

