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
        
        double firstNumber = ReadFromUserInput();
    
        double secondNumber = ReadFromUserInput();
       
        double thirdNumber = ReadFromUserInput();
   
        double forthNumber = ReadFromUserInput();
      
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
        Console.WriteLine(max);

    }

    static double ReadFromUserInput()
    {
        double number = double.Parse(Console.ReadLine());
        return number;
    }
}



