/* Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. */


using System;

class NumbersFromGivenNumber
{
    static void ReturnNumber()
    {
        int number;
        bool isParsed = int.TryParse(Console.ReadLine(), out number);
        while (isParsed = !true || number <= 0)
        {
            Console.Clear();
            Console.WriteLine("Wrong input!");
            Console.WriteLine("Please insert positive integer:");
            isParsed = int.TryParse(Console.ReadLine(), out number);
        }
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Please insert first intiger number:");
        int firstNumber = ReturnNumber();
        Console.WriteLine("Please insert second intiger number:");
        int secondNumber = ReturnNumber();
        int b = 0;
        int p = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            b = i % 5;
            if (b == 0)
            {
                p++;
                Console.Write("{0}, ", i);
            }
        }
        Console.WriteLine();
        Console.WriteLine("The answer is: {0}", p);

    }
}

