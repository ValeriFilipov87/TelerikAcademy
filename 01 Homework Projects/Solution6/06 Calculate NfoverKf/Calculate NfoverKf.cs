/*  Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k(1 < k<n< 100).
    Use only one loop.
*/

using System;
using System.Numerics;

class CalculateNfoverKf
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        var accN = (CalculateFactorial(N));
        var accK = (CalculateFactorial(K));
        var result = new BigInteger();
        result = accN / accK;
        Console.WriteLine(result);

    }

    private static BigInteger CalculateFactorial(int n)
    {
        var factorial = new BigInteger();
        factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

