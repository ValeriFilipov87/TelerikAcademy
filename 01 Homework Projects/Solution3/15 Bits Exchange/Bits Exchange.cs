/*  Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

using System;

class BitsExchange
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
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
        }

        Console.WriteLine(result);
    }
}

