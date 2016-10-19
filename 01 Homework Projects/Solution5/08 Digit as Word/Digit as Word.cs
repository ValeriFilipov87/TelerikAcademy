/*  Problem 8. Digit as Word

    Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
    Print “not a digit” in case of invalid input.
    Use a switch statement.
    Examples:

    d	    result
    2	    two
    1	    one
    0	    zero
    5	    five
   -0.1	    not a digit
    hi	    not a digit
    9	    nine
    10	    not a digit
*/

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Please input a digit between 0 - 9: ");
        string input = Console.ReadLine();
        int number;
        bool result = int.TryParse(input, out number);
        if (!result)
        {
            number = int.MaxValue;
        }

        switch (number)
        {
            case 0: Console.WriteLine("{0}  zero", number); break;
            case 1: Console.WriteLine("{0}  one", number); break;
            case 2: Console.WriteLine("{0}  two", number); break;
            case 3: Console.WriteLine("{0}  three", number); break;
            case 4: Console.WriteLine("{0}  four", number); break;
            case 5: Console.WriteLine("{0}  five", number); break;
            case 6: Console.WriteLine("{0}  six", number); break;
            case 7: Console.WriteLine("{0}  seven", number); break;
            case 8: Console.WriteLine("{0}  eight", number); break;
            case 9: Console.WriteLine("{0}  nine", number); break;
            default: Console.WriteLine("{0} is not a digit", input); break;
        }
    }

}