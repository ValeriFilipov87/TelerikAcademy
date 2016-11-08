/* Special for bace Kiko */

using System;
using System.Numerics;

class Recursion
{
    public static BigInteger acc = 1;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var result = new BigInteger();
        result = factorial(n, acc);
        Console.WriteLine(result);
    }

    private static BigInteger factorial(int n, BigInteger acc)
    {

        /*if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }*/
        if (n == 0)
        {
            return acc;
        }
        else
        {
            return factorial(n - 1, acc * n);
        }

    }
}

