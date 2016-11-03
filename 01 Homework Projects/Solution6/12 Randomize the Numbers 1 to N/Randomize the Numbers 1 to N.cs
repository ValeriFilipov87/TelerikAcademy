/*  Problem 12.* Randomize the Numbers 1…N

    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
*/

using System;

class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        Console.Write("Insert N: ");
        int N = UserInput();
        Random rnd = new Random();
        int result = new int();

        for (int i = 1; i <= N; i++)
        {
            result = rnd.Next(1, N + 1);
            Console.Write(result + " ");
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

