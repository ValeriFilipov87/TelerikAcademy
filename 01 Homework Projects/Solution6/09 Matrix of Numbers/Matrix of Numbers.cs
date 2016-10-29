/*  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. */


using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Insert N: ");
        int N = UserInput();
        while (N > 20 || N < 1)
        {
            Console.WriteLine("Wrong input! N must 1 <= n <= 20");
            Console.WriteLine("Insert N: ");
            N = UserInput();
        }
        for (int i = 1; i <= N; i++)
        {
            int j = i;
            do
            {
                Console.Write(j + " ");
                j++;
            } while (j<N+i);
            
            Console.WriteLine();
            
        }
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

