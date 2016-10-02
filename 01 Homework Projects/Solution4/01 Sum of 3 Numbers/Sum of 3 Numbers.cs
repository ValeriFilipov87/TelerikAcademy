/* Write a program that reads 3 real numbers from the console and prints their sum. */

using System;


class ProblemSumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please input first number");
        decimal firstNumber = Decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please input second number");
        decimal secondNumber = Decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please input third number");
        decimal thirdNumber = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three input numbers is {0}", firstNumber + secondNumber + thirdNumber);
    }
}

