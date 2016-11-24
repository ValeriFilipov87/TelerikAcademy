/*  Write an expression that extracts from given integer n the value of given bit at index p. */

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        long digit = long.Parse(Console.ReadLine());
      
        int position = int.Parse(Console.ReadLine());

        long mask = (1L << position);

        digit = digit & mask;
        int bit = (int)digit >> position;

        Console.WriteLine(bit);
    }
}

