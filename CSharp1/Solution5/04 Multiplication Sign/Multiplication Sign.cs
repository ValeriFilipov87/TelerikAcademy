/*  Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
    Examples:

    a	    b	    c	    result
    5	    2	    2	    +
   -2	   -2	    1	    +
   -2	    4	    3	    -
    0	   -2.5	    4	    0
   -1	   -0.5	   -5.1	    -
   */

using System;



class MultiplicationSign
{
    static void Main()
    {
        
        double firstNumber = ReadFromUserInput();
        
        double secondNumber = ReadFromUserInput();
       
        double thirdNumber = ReadFromUserInput();

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine(0);

        }
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine('+');
        }
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine('-');
        }
        if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine('-');
        }
        if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine('+');
        }
        if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine('-');
        }
        if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine('+');
        }
        if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine('-');
        }
        if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine('+');
        }
    }


    static double ReadFromUserInput()
    {
        double number = Double.Parse(Console.ReadLine());
        return number;
    }

}
