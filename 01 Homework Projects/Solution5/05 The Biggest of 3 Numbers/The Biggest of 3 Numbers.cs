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
        Console.Write("Please input first Number: ");
        double fisrtNumber = ReadFromUserInput();
        Console.Write("Please input second Number: ");
        double secondNumber = ReadFromUserInput();
        Console.Write("Please input third Number: ");
        double thirrdNumber = ReadFromUserInput();

// first option

        double[] result = new double[] { fisrtNumber, secondNumber, thirrdNumber };

        Console.WriteLine("The bigest number is: {0}", result.Max());

// second option
        if (fisrtNumber >= secondNumber)
        {
            if (secondNumber >= thirrdNumber)
            {
                Console.WriteLine("max is " + fisrtNumber);
            }
            else
            {
                Console.WriteLine("max is " + thirrdNumber);
            }
        }
        if (fisrtNumber <= secondNumber)
        {
            if (fisrtNumber >= thirrdNumber)
            {
                Console.WriteLine("max is " + secondNumber);
            }
            else if (secondNumber >= thirrdNumber)
            {
                Console.WriteLine("max is " + secondNumber);
            }
            else
            {
                Console.WriteLine("max is " + thirrdNumber);
            }
        }
    }
    static double ReadFromUserInput()
    {
        double number = double.Parse(Console.ReadLine());
        return number;
    }

}

