using System;

class Program
{
    static void Main()
    {
        long A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        long C = int.Parse(Console.ReadLine());

        long R = new long();

        if (B == 3)
        {
            R = A + C;
        }
        if (B == 6)
        {
            R = A * C;
        }
        if (B == 9)
        {
            R = A % C;
        }
        if (R % 3 == 0)
        {
            Console.WriteLine(R / 3);
            Console.WriteLine(R);
        }
        else
        {
            Console.WriteLine(R % 3);
            Console.WriteLine(R);
        }
    }
}

