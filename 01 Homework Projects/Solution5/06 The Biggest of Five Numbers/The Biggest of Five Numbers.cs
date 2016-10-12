/*  Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.
    Examples:

    a	b	    c	    d	e	    biggest
    5	2	    2	    4	1	    5
   -2  -22	    1	    0	0	    1
   -2	4	    3	    2	0	    4
    0  -2.5	    0	    5	5	    5
   -3  -0.5	   -1.1	   -2  -0.1	   -0.1

*/
using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please input first Number: ");
        double firstNumber = ReadFromUserInput();
        Console.Write("Please input second Number: ");
        double secondNumber = ReadFromUserInput();
        Console.Write("Please input third Number: ");
        double thirdNumber = ReadFromUserInput();
        Console.Write("Please input forth Number: ");
        double forthNumber = ReadFromUserInput();
        Console.Write("Please input fifth Number: ");
        double fifthNumber = ReadFromUserInput();

        double max = firstNumber;

        if (secondNumber > max)
        {
            max = secondNumber;

        }
        if (thirdNumber > max)
        {
            max = thirdNumber;

        }
        if (forthNumber > max)
        {
            max = forthNumber;

        }
        if (fifthNumber > max)
        {
            max = fifthNumber;
        }
        Console.WriteLine("max is " + max);

    }

    static double ReadFromUserInput()
    {
        double number = double.Parse(Console.ReadLine());
        return number;
    }
}



