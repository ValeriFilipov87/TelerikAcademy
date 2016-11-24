/*  The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */


using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please input weight:");
        float earthWeigth = float.Parse(Console.ReadLine());
        float coeficient = 0.17F;
        float moonWeigth = earthWeigth * coeficient;
        Console.WriteLine("{0:F3}", moonWeigth);
    }
}

