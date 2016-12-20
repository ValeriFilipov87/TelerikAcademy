using System;

class Exam3Task1PeaceOfCake
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long D = long.Parse(Console.ReadLine());

        decimal result = (((decimal)A * (decimal)D) + ((decimal)C * (decimal)B)) / ((decimal)B * (decimal)D);

        if (result >= 1)
        {
            result = (long)result;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("{0:F22}",result);
        }
        Console.WriteLine("{0}/{1}", ((A * D) + (C * B)), (B * D));
    }
}
