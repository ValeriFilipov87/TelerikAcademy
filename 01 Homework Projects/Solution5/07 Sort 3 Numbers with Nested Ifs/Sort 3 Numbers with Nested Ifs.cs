/*  Problem 7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
    Use nested if statements.
    Note: Don’t use arrays and the built-in sorting functionality.

    Examples:

    a	    b	    c	    result
    5	    1	    2	    5       2       1
   -2      -2	    1	    1      -2      -2
   -2	    4	    3	    4       3      -2
    0      -2.5	    5	    5       0      -2.5
   -1.1	   -0.5	   -0.1	   -0.1    -0.5    -1.1
    10	    20	    30	    30      20      10
    1	    1	    1	    1       1       1
*/


using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Please input first Number: ");
        double firstNumber = ReadFromUserInput();
        Console.Write("Please input second Number: ");
        double secondNumber = ReadFromUserInput();
        Console.Write("Please input third Number: ");
        double thirdNumber = ReadFromUserInput();

        double max = new double();
        double mid = new double();
        double min = new double();

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            max = firstNumber;
            if (secondNumber >= thirdNumber)
            {
                mid = secondNumber;
                min = thirdNumber;
            }
            else
            {
                mid = thirdNumber;
                min = secondNumber;
            }
        }
        if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            max = secondNumber;
            if (firstNumber >= thirdNumber)
            {
                mid = firstNumber;
                min = thirdNumber;
            }
            else
            {
                mid = thirdNumber;
                min = firstNumber;
            }
        }
        if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            max = thirdNumber;
            if (firstNumber >= secondNumber)
            {
                mid = firstNumber;
                min = secondNumber;
            }
            else
            {
                mid = secondNumber;
                min = firstNumber;
            }
        }
        Console.WriteLine("Result is: {0} {1} {2}", max, mid, min);
    }
    static double ReadFromUserInput()
    {
        double number = double.Parse(Console.ReadLine());
        return number;
    }
}

