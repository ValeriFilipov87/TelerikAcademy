/*  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. */

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please input 5 digits:");
        string inputNumber = Console.ReadLine();
        int length = 0;
        var array = inputNumber.Split(' ');
        if (inputNumber[inputNumber.Length - 1] == ' ')
        {
            length = array.Length - 1;
        }
        else
        {
            length = array.Length;
        }
        decimal y = new decimal();
        decimal result = new decimal();
        for (int i = 0; i < length; i++)
        {
            y = decimal.Parse(array[i]);
            result = y + result;
        }
        Console.WriteLine(result);

    }
}