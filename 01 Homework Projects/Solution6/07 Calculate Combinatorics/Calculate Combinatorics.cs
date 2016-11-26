/*  Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements 
    (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class CalculateCombinatorics
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        var accN = CalculateFactorial(N);
        var accK = CalculateFactorial(K);
        var accNMinusK = CalculateFactorial(N - K);
        var result = new BigInteger();
        result = accN / (accK * accNMinusK);
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

