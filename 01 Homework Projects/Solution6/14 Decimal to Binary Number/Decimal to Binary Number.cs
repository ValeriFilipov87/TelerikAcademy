/*  Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
*/

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long digit = long.Parse(Console.ReadLine());
        string result = "";
        long remainder = new long();
        char binary = new char();
        do
        {
            remainder = digit % 2 + 48;
            digit = digit / 2;
            binary = (char)remainder;
            result = result + binary;
        } while (digit != 0);
        result = ReverseString(result);
        Console.WriteLine(result);
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

