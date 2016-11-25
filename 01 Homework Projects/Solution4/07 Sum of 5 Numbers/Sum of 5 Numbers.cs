/*  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. */

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        int[] input = new int[5];
        int sum = new int();
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
            sum += input[i];
        }
        Console.WriteLine(sum);
    }
        
}