using System;

class Exam3Task4Eggcelent
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.Write(new string('.', N + 1));
        Console.Write(new string('*', N - 1));
        Console.Write(new string('.', N + 1));
        Console.WriteLine();

        for (int i = 0; i < (N / 2)-1; i++)
        {
            Console.Write(new string('.', N - 2 * i - 1));
            Console.Write('*');
            Console.Write(new string('.', N + 1 + 4 * i));
            Console.Write('*');
            Console.Write(new string('.', N - 2 * i - 1));
            Console.WriteLine();
        }
        for (int i = 0; i < N/2-1; i++)
        {
            Console.Write('.');
            Console.Write('*');
            Console.Write(new string('.', 3 * N - 3));
            Console.Write('*');
            Console.Write('.');
            Console.WriteLine();
        }
      

        Console.Write('.');
        Console.Write('*');
        for (int i = 0; i < 3 * N - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.Write('*');
        Console.Write('.');
        Console.WriteLine();

        Console.Write('.');
        Console.Write('*');
        for (int i = 0; i < 3 * N - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('.');
            }
            else
            {
                Console.Write('@');
            }
        }
        Console.Write('*');
        Console.Write('.');
        Console.WriteLine();

        for (int i = 0; i < N / 2 - 1; i++)
        {
            Console.Write('.');
            Console.Write('*');
            Console.Write(new string('.', 3 * N - 3));
            Console.Write('*');
            Console.Write('.');
            Console.WriteLine();
        }


        for (int i = ((N / 2) - 2); i >= 0; i--)
        {
            Console.Write(new string('.', N - 2 * i - 1));
            Console.Write('*');
            Console.Write(new string('.', N + 1 + 4 * i));
            Console.Write('*');
            Console.Write(new string('.', N - 2 * i - 1));
            Console.WriteLine();
        }

        Console.Write(new string('.', N + 1));
        Console.Write(new string('*', N - 1));
        Console.Write(new string('.', N + 1));
        Console.WriteLine();
    }
}

