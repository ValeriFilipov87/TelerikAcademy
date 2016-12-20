/* Write an expression that calculates trapezoid's area by given sides a and b and height h. */


using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("You must enter a side of the trapezoid");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("You must enter b side of the trapezoid");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("You must enter h side of the trapezoid");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is: {0}", area);
    }
}

