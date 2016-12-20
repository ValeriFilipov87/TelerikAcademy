using System;


class Exam3Task3OnesAndZeros
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(number, 2);

        binary = binary.PadLeft(32, '0');

        for (int i = 16; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write("###");
            }
            else
            {
                Console.Write(".#.");
            }
            if (i != binary.Length - 1)
            {
                Console.Write('.');
            }
        }
        Console.WriteLine();
        for (int i = 16; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write("##.");
            }
            if (i != binary.Length - 1)
            {
                Console.Write('.');
            }
        }
        Console.WriteLine();
        for (int i = 16; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write(".#.");
            }
            if (i != binary.Length - 1)
            {
                Console.Write('.');
            }
        }
        Console.WriteLine();
        for (int i = 16; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write(".#.");
            }
            if (i != binary.Length - 1)
            {
                Console.Write('.');
            }
        }
        Console.WriteLine();
        for (int i = 16; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write("###");
            }
            else
            {
                Console.Write("###");
            }
            if (i != binary.Length - 1)
            {
                Console.Write('.');
            }
        }
        Console.WriteLine();
    }
}
