using System;

class Exam2Task2TheHorror
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = new int();
        long sum = new long();

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsDigit(input[i]))
            {
                if (i % 2 == 0)
                {
                    count++;
                    sum += (input[i]-'0');
                }
            }
        }
        Console.WriteLine("{0} {1}", count, sum);
    }
}

