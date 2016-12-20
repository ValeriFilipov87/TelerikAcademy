/*  Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. */

using System;


class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Input circle radius: ");
        double radius = Double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.Pow(radius,2) * Math.PI;
        Console.WriteLine("The circle radius is {0:F2}", perimeter);
        Console.WriteLine("The circle area is {0:F2}", area);

    }
}

