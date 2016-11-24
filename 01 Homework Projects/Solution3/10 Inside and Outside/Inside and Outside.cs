/* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class InsideAndOutside
{
    static void Main()
    {
        //Console.WriteLine("You must enter x coordinate of a point");
        double xCoordinate = double.Parse(Console.ReadLine());
        //Console.WriteLine("You must enter y coordinate of a point");
        double yCoordinate = double.Parse(Console.ReadLine());

        double hypothenuse = Math.Pow((xCoordinate - 1), 2) + Math.Pow(yCoordinate - 1, 2);
        double R = 1.5;

        bool checkCircle = Math.Sqrt(hypothenuse) <= R;

        bool checkRectangle = xCoordinate >= -1 && xCoordinate <= 5 && yCoordinate <= 1 && yCoordinate >= -1;

        if (checkCircle == true)
        {
            if (checkRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("inside circle outside rectangle");
            }
        }
        else
        {
            if (checkRectangle == true)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }

    }
}

