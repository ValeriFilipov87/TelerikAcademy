/*  Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;
using System.Numerics;

class CalculateCatalanNumbers
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        var acc2N = CalculateFactorial(2 * N);
        var accNPlus1 = CalculateFactorial(N + 1);
        var accN = CalculateFactorial(N);
        var result = new BigInteger();
        result = acc2N / (accNPlus1 * accN);
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

