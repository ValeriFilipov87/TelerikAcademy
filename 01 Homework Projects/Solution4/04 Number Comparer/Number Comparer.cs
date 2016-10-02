/*  Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements. */

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Input first digit: ");
        double x = Double.Parse(Console.ReadLine());
        Console.Write("Input second difit: ");
        double y = Double.Parse(Console.ReadLine());
        double max = Math.Max(x, y);
        Console.WriteLine("The bigger digit is: {0}", max);
    }
}

