/*  Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

*/

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        char[] hexadecimal = UserInput();
        long result = 0;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if (hexadecimal[i] == 'A')
            {
                result = result + 10 * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else if (hexadecimal[i] == 'B')
            {
                result = result + 11 * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else if (hexadecimal[i] == 'C')
            {
                result = result + 12 * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else if (hexadecimal[i] == 'D')
            {
                result = result + 13 * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else if (hexadecimal[i] == 'E')
            {
                result = result + 14 * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else if (hexadecimal[i] == 'F')
            {
                result = result + 15 * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else
            {
                result = result + (long)Char.GetNumericValue(hexadecimal[i]) * ((long)Math.Pow(16, hexadecimal.Length - i - 1));
            }
        }
        Console.WriteLine(result);
    }

    private static char[] UserInput()
    {
        string input = Console.ReadLine();
        char[] hexa = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            hexa[i] = input[i];
        }
        return hexa;
    }
}

