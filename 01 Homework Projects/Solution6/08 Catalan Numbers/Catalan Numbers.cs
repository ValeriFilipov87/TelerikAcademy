/*  Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
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


        var acc2N = CalculateFactorial(2 * N);
        var accNPlus1 = CalculateFactorial(N + 1);
        var accN = CalculateFactorial(N);
        var result = new BigInteger();
        result = acc2N / (accNPlus1 * accN);
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

