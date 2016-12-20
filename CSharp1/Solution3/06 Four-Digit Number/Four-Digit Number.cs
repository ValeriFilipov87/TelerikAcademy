/*  Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101). */


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("You must enter a positive 4-digit number");
        int number = int.Parse(Console.ReadLine());
        Console.Clear();

        while (number > 9999 || number < 1000 || number < 0)
        {
            Console.Clear();
            Console.WriteLine("The input number is not a positive 4 - digit number!");

            Console.WriteLine("You must enter a positive 4-digit number");
            number = int.Parse(Console.ReadLine());        
        }
        string digit = Convert.ToString(number);
        //Console.WriteLine("Please input a 4 digit:");
        //string digit = Console.ReadLine(); //read and save the input number as a string

        char[] charArray = digit.ToCharArray(); //convert the string to an array of chars
        int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c)); //convert the array of chars to an array of ints

        Console.WriteLine("The sum of the digit is: {0}", intArray[0] + intArray [1] + intArray[2] + intArray[3]);
        Console.WriteLine("The number in the reverserd order is: {0}{1}{2}{3}", intArray[3], intArray[2], intArray[1], intArray[0]);
        Console.WriteLine("The last digit in the first position is: {0}{1}{2}{3}", intArray[3], intArray[0], intArray[1], intArray[2]);
        Console.WriteLine("The exchange the second and the third digits is: {0}{1}{2}{3}", intArray[0], intArray[2], intArray[1], intArray[3]);
    }
}