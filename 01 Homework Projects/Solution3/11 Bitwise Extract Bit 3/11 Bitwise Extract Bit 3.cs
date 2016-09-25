/*  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0. */

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Input an unsigned integer:");
        double digit = double.Parse(Console.ReadLine());
        double digit1 = Math.Ceiling(digit);
        bool check = (digit == digit1) && (digit >= 0); // check if the 1st input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
        while (check == false) // cycle which will check each input digit after the first one which is wrong, until a correct digit is input
        {
            Console.Clear();
            Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number");
            digit = double.Parse(Console.ReadLine());
            digit1 = Math.Ceiling(digit);
            check = (digit == digit1) && (digit >= 0); // check if the next input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
        }

        int checkNumber = Convert.ToInt32(digit);
        int position = 3;
        int mask = 1 << position;
        int nAndMask = checkNumber & mask;  
        int bit = nAndMask >> position;  
        Console.WriteLine("The bit on position #3 is: {0}",bit);
    }
}

