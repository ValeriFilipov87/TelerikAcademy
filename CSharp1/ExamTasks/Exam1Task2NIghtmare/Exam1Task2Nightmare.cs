using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int count = 0;
        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                if (i % 2 == 1)
                {
                    int digit = Convert.ToInt32(input[i]) - '0';
                    count++;
                    sum += digit;
                }
            }
        }
        Console.WriteLine("{0} {1}", count, sum);
    }
}

