using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.Write(new string('.', N));
        Console.Write('*');
        Console.Write(new string('.', N));
        Console.WriteLine();

        for (int i = N - 1; i > 0; i--)
        {
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', N - 1 - i));
            Console.Write('*');
            Console.Write(new string('.', N - 1 - i));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.WriteLine();
        }

        Console.Write(new string('*', 2 * N + 1));
        Console.WriteLine();

        for (int i = 1; i < N / 2 + 1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', N - 1 - i));
            Console.Write('*');
            Console.Write(new string('.', N - 1 - i));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.WriteLine();
        }

        Console.Write(new string('.', N / 2 + 1));
        Console.Write(new string('*', N));
        Console.Write(new string('.', N / 2 + 1));
        Console.WriteLine();
    }
}

