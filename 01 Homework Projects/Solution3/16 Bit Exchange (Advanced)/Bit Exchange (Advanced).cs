/*  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap. */


using System;

class BitExchangeAdvanced
{
    static void Main()
    {


        long n = long.Parse(Console.ReadLine());


        int p = int.Parse(Console.ReadLine());

        int q = int.Parse(Console.ReadLine());

        int k = int.Parse(Console.ReadLine());
        int j = p;
        long result = n;
        long mask;

        for (int i = p; i <= ((j + k) - 1); i++)
        {
            int maskp = 1 << p;
            long bitp = (n & maskp) >> p;
            int maskq = 1 << q;
            long bitq = (n & maskq) >> q;
            if (bitp != bitq)
            {
                if (bitp == 1 && bitq == 0)
                {
                    mask = ~(1 << p);
                    result = result & mask;
                    mask = 1 << q;
                    result = result | mask;
                }
                else
                {
                    mask = 1 << p;
                    result = result | mask;
                    mask = ~(1 << q);
                    result = result & mask;
                }

            }
            p++;
            q++;
        }
        Console.WriteLine(result);
    }
}

