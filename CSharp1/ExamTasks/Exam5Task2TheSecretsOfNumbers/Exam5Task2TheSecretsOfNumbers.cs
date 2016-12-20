using System;

class Exam5Task2TheSecretsOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = new int();
        int position = 1;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                int digit = input[i] - '0';
                if (position % 2 == 1)
                {
                    sum += digit * position * position;
                }
                if (position % 2 == 0)
                {
                    sum += digit * digit * position;
                }
                position++;
            }
        }
        int sequence = sum % 10;
        Console.WriteLine(sum);
        if (sequence == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", input);
        }
        else
        {
            int R = sum % 26;
            for (int i = 0; i < sequence; i++)
            {
                Console.Write((char)((R + i) % 26 + 'A'));
            }
            Console.WriteLine();
        }
    }
}
