/*  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0. */

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int nAndMask = digit & mask;
        int bit = nAndMask >> position;
        Console.WriteLine(bit);
    }
}

