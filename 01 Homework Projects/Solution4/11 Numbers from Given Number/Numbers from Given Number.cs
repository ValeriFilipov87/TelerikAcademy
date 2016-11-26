/* Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. */


using System;

class NumbersFromGivenNumber
{

    static void Main()
    {

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber < 0)
        {
            firstNumber *= -1;
        }
        if (secondNumber < 0)
        {
            secondNumber *= -1;
        }
        int b = 0;
        int p = 0;
        for (int i = firstNumber + 1; i < secondNumber; i++)
        {
            b = i % 5;
            if (b == 0)
            {
                p++;
            }
        }
        Console.WriteLine(p);

    }
}

