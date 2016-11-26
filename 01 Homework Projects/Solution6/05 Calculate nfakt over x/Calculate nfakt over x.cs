/*  Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
*/

using System;

class CalculateNfaktOverX
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double X = double.Parse(Console.ReadLine());
        double square = new double();
        double temp = new double();
        long factorial = 1;
        double result = 1;
        for (int i = 1; i <= N; i++)
        {
            factorial *= i;
            square = Math.Pow(X, i);
            temp = factorial / square;
            result = result + temp;
        }
        Console.WriteLine("{0:F5}", result);
    }  
}

