/* Write an expression that checks for given integer if its third digit from right-to-left is 7. */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a digit:");
        string digit = Console.ReadLine(); //read and save the input number as a string

        char[] charArray = digit.ToCharArray(); //convert the string to an array of chars
        int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c)); //convert the array of chars to an array of ints   

        int length = digit.Length; // find the position of the 3rd digit in the array from right to left
        int position = length - 3; 

        if (intArray[0]  == 7 ) // compare the chosen digit with the wanted value
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        } 

    }
}

