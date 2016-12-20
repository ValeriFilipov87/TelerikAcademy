using System;

class Exam5Task4Tower
{
    static void Main(string[] args)
    {
        int H = int.Parse(Console.ReadLine());
        int[] result = new int[H];
        result[0] = 0;
        int j = 0;
        for (int i = 1; i < H; i++)
        {
            result[i] = result[i-1] + i;
        }
        for (int i = 0; i < H; i++)
        {            
            Console.Write(new string('.', H - 1 - i));
            Console.Write('/');
            if (i == result[j])
            {                
                j++;
                Console.Write(new string('-', 2 * i));
            }
            else
            {
                Console.Write(new string('.', 2 * i));
            }
            Console.Write('\\');
            Console.Write(new string('.', H - 1 - i));
            Console.WriteLine();
        }
    }
}

