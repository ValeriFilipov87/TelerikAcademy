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
        Console.Write("Insert N: ");
        int N = UserInput();
        while (N >= 100)
        {
            Console.WriteLine("Wrong input! N must be less than 100");
            Console.WriteLine("Insert N: ");
            N = UserInput();
        }

        Console.Write("Insert K: ");
        int K = UserInput();
        while (K >= N)
        {
            Console.WriteLine("Wrong input! K must be less than N");
            Console.WriteLine("Insert K: ");
            K = UserInput();
        }

        var accN = (CalculateFactorial(N));
        var accK = (CalculateFactorial(K));
        var result = new BigInteger();
        result = accN / accK;
        Console.WriteLine("Result is: {0}", result);

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

    private static int UserInput()
    {
        int input = new int();
        bool check = int.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong!");
            check = int.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}

