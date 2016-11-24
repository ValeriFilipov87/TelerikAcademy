/*  We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. */

using System;
class Program
{
    static void Main()
    {

        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        // check a bit in a given position
        ulong mask = 1UL << p;
        ulong nAndMask = (uint)n & mask;
        int bit = (int)nAndMask >> p;
        bool check = bit == v;

        //Print the result if the value of the checked bit is the same with the one that we want to make it to:
        if (check)
        {
            Console.WriteLine(n);
        }
        else
        {
            if (bit == 1)
            {
                mask = ~(1UL << p);
                ulong result = n & mask;
                Console.WriteLine(result);
            }
            else
            {
                mask = 1UL << p;
                ulong result = n | mask;
                Console.WriteLine(result);
            }
        }
    }
}

