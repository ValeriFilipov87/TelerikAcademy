using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Triangle_surface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            //double side = double.Parse(Console.ReadLine());
            //double altitude = double.Parse(Console.ReadLine());
            //double surface = (side * altitude) / 2;
            //Console.WriteLine("{0:F2}",surface);

            //double firstSide = double.Parse(Console.ReadLine());
            //double secondSide = double.Parse(Console.ReadLine());
            //double thirdSide = double.Parse(Console.ReadLine());
            //double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            //double surface = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
            //Console.WriteLine("{0:F2}", surface);

            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            double sinA = Math.Sin((Math.PI / 180) * angle);
            double surface = ((firstSide * secondSide) / 2) * sinA;
            Console.WriteLine("{0:F2}", surface);
        }
    }
}
