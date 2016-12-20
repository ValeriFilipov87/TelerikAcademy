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
    
        int firstNumber = ReadFromUserInput();
       
        int secondNumber = ReadFromUserInput();
      
        int thirdNumber = ReadFromUserInput();

        int max = new int();
        int mid = new int();
        int min = new int();

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
        Console.WriteLine("{0} {1} {2}", max, mid, min);
    }
    static int ReadFromUserInput()
    {
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}

