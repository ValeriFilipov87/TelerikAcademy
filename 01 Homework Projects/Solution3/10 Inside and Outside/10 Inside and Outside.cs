/* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("You must enter x coordinate of a point");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("You must enter y coordinate of a point");
        double yCoordinate = double.Parse(Console.ReadLine());

        double hypothenuse = Math.Pow((xCoordinate-1), 2) + Math.Pow(yCoordinate-1, 2);
        double R = 1.5;
        bool checkCircle = Math.Sqrt(hypothenuse) <= R;

        if (checkCircle)
        {
            Console.WriteLine("The given point is inside the circle");
        }
        else
        {
            Console.WriteLine("The given point is not inside the circle");
        }

        bool checkRectangle = xCoordinate >= -1 && xCoordinate <= 5 && yCoordinate <= 1 && yCoordinate >= -1;

        if (checkRectangle)
        {
            Console.WriteLine("The given point is inside the rectangle");
        }
        else
        {
            Console.WriteLine("The given point is not inside the rectangle");
        }

        if (checkCircle == true && checkRectangle == false)
        {
            Console.WriteLine("The condition is fullfilled");
        }
        else
        {
            Console.WriteLine("The condition is not fullfilled");
        }
    }
}

