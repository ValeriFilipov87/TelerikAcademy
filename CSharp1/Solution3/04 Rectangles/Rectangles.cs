/* Write an expression that calculates rectangle’s perimeter and area by given width and height. */

using System;
class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a value for width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please input a value for height:");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        Console.WriteLine("The perimeter is: {0}\nThe area is: {1}", perimeter, area);
    }
}

