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
        int digit = ReadFromUserInput();
        ApplyScoreCalculation(digit);
    }

    private static void ApplyScoreCalculation(int a)
    {
        if (a >= 1 && a <= 3)
        {
            Console.WriteLine(a * firstMultiplier);
        }
        if (a >= 4 && a < 7)
        {
            Console.WriteLine(a * secondMultiplier);
        }
        if (a >= 7 && a < 10)
        {
            Console.WriteLine(a * thirdMultiplier);
        }
        if (a >= 10 || a < 1)
        {
            Console.WriteLine("invalid score");
        }
    }

    static int ReadFromUserInput()
    {
        int number = int.Parse(Console.ReadLine());
        return number;
    }

}
