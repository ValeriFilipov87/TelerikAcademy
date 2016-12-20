/* Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop. */

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        decimal result = 0;

        for (int i = 0; i < number; i++)
        {
            decimal additionalNumbers = decimal.Parse(Console.ReadLine());
            result = result + additionalNumbers;
        }
        Console.WriteLine(result);
    }
}

