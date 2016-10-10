/*  Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    If the score is between 1 and 3, the program multiplies it by 10.
    If the score is between 4 and 6, the program multiplies it by 100.
    If the score is between 7 and 9, the program multiplies it by 1000.
    If the score is 0 or more than 9, the program prints “invalid score”.
    Examples:
    
    score	result
    2	20
    4	400
    9	9000
    -1	invalid score
    10	invalid score */


using System;

class BonusScore
{
    public static int firstMultiplier = 10;
    public static int secondMultiplier = 100;
    public static int thirdMultiplier = 1000;

    static void Main()
    {
        Console.Write("Please input a number from 1 to 9: ");
        double digit = ReadFromUserInput();
        digit = CheckNumber(digit);

        ApplyScoreCalculation(digit);
    }

    private static void ApplyScoreCalculation(double a)
    {
        if (a >= 1 && a < 3)
        {
            Console.WriteLine("Score is: {0}", a * firstMultiplier);
        }
        if (a >= 3 && a < 6)
        {
            Console.WriteLine("Score is: {0}", a * secondMultiplier);
        }
        if (a >= 6 && a < 10)
        {
            Console.WriteLine("Score is: {0}", a * thirdMultiplier);
        }
    }

    static double ReadFromUserInput()
    {
        double number = Double.Parse(Console.ReadLine());
       // CheckNumber(number);
        return number;
    }

    private static double CheckNumber(double number)
    {

        while (number > 9 || number <= 0)
        {
            Console.Clear();
            Console.Write("The input number is incorrect");
            Console.Write("Please, try again: ");
            number = ReadFromUserInput();
        }
        return number;
    }
}
