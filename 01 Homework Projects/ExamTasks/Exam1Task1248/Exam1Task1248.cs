using System;

class Program
{
    static void Main()
    {
        long A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        long C = int.Parse(Console.ReadLine());

        long R = new long();

        if (B == 2)
        {
            R = A % C;
        }
        if (B == 4)
        {
            R = A + C;
        }
        if (B == 8)
        {
            R = A * C;
        }
        if (R % 4 == 0)
        {
            Console.WriteLine(R/4);
            Console.WriteLine(R);
        }
        else
        {
            Console.WriteLine(R%4);
            Console.WriteLine(R);
        }
    }
}

