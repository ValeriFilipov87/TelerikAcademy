/*  Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

using System;

class BitsExchange
{
    static void Main()
    {
        //insert the integer number which should be modified
        Console.WriteLine("Input an unsigned integer:");
        double digit = double.Parse(Console.ReadLine());
        double digit1 = Math.Ceiling(digit);
        bool checkNumber = (digit == digit1) && (digit >= 0); // check if the 1st input digit is: 1. Intiger; 2. Positive 
        while (checkNumber == false) // cycle which will check each input digit after the first one which is wrong, until a correct digit is input
        {
            Console.Clear();
            Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number:");
            digit = double.Parse(Console.ReadLine());
            digit1 = Math.Ceiling(digit);
            checkNumber = (digit == digit1) && (digit >= 0); // check if the next input digit is: 1. Intiger; 2. Positive 
        }

        int n = Convert.ToInt32(digit);         // the input number number
        Console.WriteLine("The input value is:\n{0}\nThe input value in duoble is:\n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        int mask;
        mask = 1 << 3;
        int thirdBit = (n & mask) >> 3;
        mask = 1 << 4;
        int forthBit = (n & mask) >> 4;
        mask = 1 << 5;
        int fifthBit = (n & mask) >> 5;
        mask = 1 << 24;
        int twForthBit = (n & mask) >> 24;
        mask = 1 << 25;
        int twFifthBit = (n & mask) >> 25;
        mask = 1 << 26;
        int twSixthBit = (n & mask) >> 26;

        bool checkFirstPair = thirdBit != twForthBit;
        bool checkSecondPair = forthBit != twFifthBit;
        bool checkThirdPair = fifthBit != twSixthBit;

        int result = n;

        if (checkFirstPair)
        {
            if (thirdBit == 1 && twForthBit == 0)
            {
                mask = ~(1 << 3);
                result = result & mask;
                mask = 1 << 24;
                result = result | mask;
            }
            else
            {
                mask = 1 << 3;
                result = result | mask;
                mask = ~(1 << 24);
                result = result & mask;
            }
            Console.WriteLine("After changing 3rd and 24th bit:\n{0}", result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("3rd and 24th bits are iqual");
        }

        if (checkSecondPair)
        {
            if (forthBit == 1 && twFifthBit == 0)
            {
                mask = ~(1 << 4);
                result = result & mask;
                mask = 1 << 25;
                result = result | mask;
            }
            else
            {
                mask = 1 << 4;
                result = result | mask;
                mask = ~(1 << 25);
                result = result & mask;
            }
            Console.WriteLine("After changing 4th and 25th bit:\n{0}", result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("4th and 25th bits are iqual");
        }

        if (checkThirdPair)
        {
            if (fifthBit == 1 && twSixthBit == 0)
            {
                mask = ~(1 << 5);
                result = result & mask;
                mask = 1 << 26;
                result = result | mask;
            }
            else
            {
                mask = 1 << 5;
                result = result | mask;
                mask = ~(1 << 26);
                result = result & mask;
            }
            Console.WriteLine("After changing 5th and 26th bit:\n{0}", result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("4th and 26th bits are iqual");
        }
    }
}

