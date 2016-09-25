/*  Write an expression that extracts from given integer n the value of given bit at index p. */

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Input an unsigned integer:");
        double digit = double.Parse(Console.ReadLine());
        double digit1 = Math.Ceiling(digit);
        bool checkNumber = (digit == digit1) && (digit >= 0); // check if the 1st input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
        while (checkNumber == false) // cycle which will check each input digit after the first one which is wrong, until a correct digit is input
        {
            Console.Clear();
            Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number");
            digit = double.Parse(Console.ReadLine());
            digit1 = Math.Ceiling(digit);
            checkNumber = (digit == digit1) && (digit >= 0); // check if the next input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
        }
        Console.WriteLine("Input an unsigned integer:");
        double position = double.Parse(Console.ReadLine());
        double position1 = Math.Ceiling(position);
        bool checkPosition = (position == position1) && (digit >= 0) && (position <= 32);
        while (checkPosition == false)
        {
            Console.Clear();
            Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number");
            position = double.Parse(Console.ReadLine());
            position1 = Math.Ceiling(position);
            checkPosition = (position == position1) && (digit >= 0) && (position <= 32);
        }
        int checkDigit = Convert.ToInt32(digit);
        int newPosition = Convert.ToInt32(position);
        int mask = 1 << newPosition;
        int nAndMask = checkDigit & mask;
        int bit = nAndMask >> newPosition;
        Console.WriteLine(Convert.ToString(checkDigit, 2).PadLeft(16, '0'));
        Console.WriteLine("The bit on position {0} is: {1}", newPosition, bit);
    }
}

