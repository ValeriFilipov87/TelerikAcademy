/*  Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
*/

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int input = UserInput();
        Console.WriteLine();
        FirstSolution(input);
        Console.WriteLine("\n");
        SeondSolution(input);
        Console.WriteLine();
    }

    private static void SeondSolution(int input)
    {
        for (int i = 1; i <= input; i++) // Second solution
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    private static void FirstSolution(int input)
    {
        int start = 1;
        while (start <= input) // First solution
        {
            Console.Write(start + " ");
            start++;
        }
    }

    private static int UserInput()
    {
        int input = new int();
        Console.WriteLine("Please input intiger number!");
        bool check = int.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong! Please input intiger number!");
            check = int.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}

