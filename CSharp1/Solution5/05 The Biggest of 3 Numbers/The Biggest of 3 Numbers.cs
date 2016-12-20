/*  Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.
    Examples:

    a       b       c       biggest
    5	    2	    2	    5
   -2      -2	    1	    1
   -2	    4	    3	    4
    0      -2.5	    5	    5
   -0.1	   -0.5	   -1.1	   -0.1

*/

using System;
using System.Linq;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        
        double fisrtNumber = ReadFromUserInput();
        
        double secondNumber = ReadFromUserInput();
       
        double thirdNumber = ReadFromUserInput();

        double max = new double();

// first option

        /*double[] result = new double[] { fisrtNumber, secondNumber, thirrdNumber };

        Console.WriteLine(result.Max());*/

// second option
        if (fisrtNumber >= secondNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                max = fisrtNumber;
            }
            else if (fisrtNumber >= thirdNumber)
            {
                max = fisrtNumber;
            }
            else
            {
                max = thirdNumber;
            }
        }
        if (fisrtNumber <= secondNumber)
        {
            if (fisrtNumber >= thirdNumber)
            {
                max = secondNumber;
            }
            else if (secondNumber >= thirdNumber)
            {
                max = secondNumber;
            }
            else
            {
                max = thirdNumber;
            }
        }
        Console.WriteLine(max);
    }
    static double ReadFromUserInput()
    {
        double number = double.Parse(Console.ReadLine());
        return number;
    }

}

