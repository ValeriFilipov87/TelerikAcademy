using System;

class Exam4Task4Fire
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', N / 2 - 1 - i));
            Console.Write('#');
            Console.Write(new string('.', i));
            Console.Write(new string('.', i));
            Console.Write('#');
            Console.Write(new string('.', N / 2 - 1 - i));
            Console.WriteLine();      
        }
        for (int i = 0; i < N/4; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('#');
            Console.Write(new string('.', N / 2 - 1 - i));
            Console.Write(new string('.', N / 2 - 1 - i));
            Console.Write('#');
            Console.Write(new string('.', i));
            Console.WriteLine();
        }

        Console.Write(new string('-', N));
        Console.WriteLine();

        for (int i = 0; i < N/2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', N / 2 - i));
            Console.Write(new string('/', N / 2 - i));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
    }
}

