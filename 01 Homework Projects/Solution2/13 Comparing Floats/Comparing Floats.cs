/* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. */

using System;

class ComparingFloats
{
        static void Main()
        {
            Double eps = 0.000000000001;
            Console.WriteLine("Write your first floating number");
            float firstNumber = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write your second floating number");
            float secondNumber = (float)Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(firstNumber - secondNumber) < eps)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("B > A");
            }
        }
}
