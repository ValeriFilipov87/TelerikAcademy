/*  Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
*/

using System;
using System.Collections.Generic;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please input number in binary form");
        string input = UserInput();
        long result = 0;

        for (int i = 0; i < input.Length; i++)
        {

            result = result + (long)Char.GetNumericValue(input[i]) * ((long)Math.Pow(2, input.Length - i - 1));
        }
        Console.WriteLine(result);
    }

    private static string UserInput()
    {
        string binaryDigit = "";
        bool flag = true;
        int count = 0;
        while (flag)
        {
            Console.Clear();
            Console.WriteLine("Please input number in binary form");
            binaryDigit = Console.ReadLine();
            for (int i = 0; i < binaryDigit.Length; i++)
            {
                if (binaryDigit[i] != '0' && binaryDigit[i] != '1')
                {
                    Console.WriteLine("Wrong Input! The input must be only 0s and 1s!");
                    break;
                }
                else
                {
                    count++;
                }
                if (count == binaryDigit.Length)
                {
                    flag = false;
                }
            }
        }
        return binaryDigit;
    }
}

