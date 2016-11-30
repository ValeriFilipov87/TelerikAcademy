using System;

class Exam2Task4DiamondTrolls
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.Write(new string('.', N / 2 + 1));
        Console.Write(new string('*', N));
        Console.Write(new string('.', N / 2 + 1));
        Console.WriteLine();
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', N / 2 - i));
            Console.Write('*');
            Console.Write(new string('.', N / 2 + i));
            Console.Write('*');
            Console.Write(new string('.', N / 2 + i));
            Console.Write('*');
            Console.Write(new string('.', N / 2 - i));
            Console.WriteLine();
        }
        Console.Write(new string('*', 2 * N + 1));
        Console.WriteLine();
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string('.', 1 + i));
            Console.Write('*');
            Console.Write(new string('.', N - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', N - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', 1 + i));
            Console.WriteLine();
        }
        Console.Write(new string('.', N));
        Console.Write('*');
        Console.Write(new string('.', N));
        Console.WriteLine();
    }
}
