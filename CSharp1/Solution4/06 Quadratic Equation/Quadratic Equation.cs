/*  Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

class QuadraticEquation
{
    static void Main()
    {
       
        double a = double.Parse(Console.ReadLine());
     
        double b = double.Parse(Console.ReadLine());
      
        double c = double.Parse(Console.ReadLine());
        double descriminant = (b * b) - 4 * (a * c);
        if (descriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double x1 = (-1 * b - Math.Sqrt(descriminant)) / (2 * a);
            double x2 = (-1 * b + Math.Sqrt(descriminant)) / (2 * a);
            if (x1 == x2)
            {
                Console.WriteLine("{0:F2}", x1);
            }
            else if (x1 > x2)
            {
                Console.WriteLine("{0:F2}\n{1:F2}", x2, x1);
            }
            else
            {
                Console.WriteLine("{0:F2}\n{1:F2}", x1, x2);
            }
        }
    }
}

