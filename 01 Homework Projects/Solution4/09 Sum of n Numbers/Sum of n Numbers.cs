/* Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop. */

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int number;
        decimal result = 0;
        decimal additionalNumbers = 0;

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
            additionalNumbers = decimal.Parse(Console.ReadLine());
            result = result + additionalNumbers;
        }
        Console.WriteLine(result);
    }
}

