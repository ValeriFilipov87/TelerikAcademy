/*  Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Input coefficients for a,b and c:");
        Console.WriteLine("ax^2 + bx+ c = 0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double descriminant = (b * b) - 4 * (a * c);
        if (descriminant < 0)
        {
            Console.WriteLine("No real roots");
        }
        else
        {
            double x1 = (-1 * b - Math.Sqrt(descriminant)) / (2 * a);
            double x2 = (-1 * b + Math.Sqrt(descriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}

