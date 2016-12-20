/*  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. */


using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int j = i;
            do
            {
                Console.Write(j + " ");
                j++;
            } while (j < N + i);

            Console.WriteLine();
        }
    }
}

