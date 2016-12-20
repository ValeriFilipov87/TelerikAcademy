/*  Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
*/

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please input length of the sequence: ");
        int lengthSequence = UserInput();
        Console.WriteLine("Length of the sequence is: {0}", lengthSequence);
        Console.WriteLine("Please input {0} digits", lengthSequence);
        int[] sequence = new int[lengthSequence];
        int max = new int();
        int min = new int();
        int sum = new int();
        double avg = new double();

        for (int i = 0; i < lengthSequence; i++)
        {
            sequence[i] = UserInput();
            max = sequence[0];
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
        }
        Console.WriteLine("Max: {0}", max);
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

