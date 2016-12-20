/*  Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
*/


using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        char[] hexSymbols = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', };
        string result = "";
        char temp = new char();
        long reminder = new long();
        long digit = UserInput();
        do
        {
            reminder = digit % 16;
            digit = digit / 16;
            temp = hexSymbols[reminder];
            result = result + temp;
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

