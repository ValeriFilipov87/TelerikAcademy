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
        Console.Write("Input a digit: ");
        long digit = UserInput();
        string result = "";
        long a = 0;
        char binary = new char();
        do
        {
            a = digit % 2 + 48;
            digit = digit / 2;
            binary = (char)a;
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

    private static long UserInput()
    {
        long input = new long();
        bool check = long.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong!");
            check = long.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}

