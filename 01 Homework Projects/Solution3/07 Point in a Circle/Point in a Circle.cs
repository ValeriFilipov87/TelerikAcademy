/* Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2) */

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("You must enter x coordinate of a point");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("You must enter y coordinate of a point");
        double yCoordinate = double.Parse(Console.ReadLine());

        double check = Math.Pow(xCoordinate,2) + Math.Pow(yCoordinate,2);
        if (Math.Sqrt(check) <= 2)
        {
            Console.WriteLine("The given point is inside a circle with radius 2");
        }
        else
        {
            Console.WriteLine("The given point is not inside a circle with radius 2");
        }
    }
}

