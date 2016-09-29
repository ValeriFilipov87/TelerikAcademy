/*  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap. */


using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        //insert the integer number which should be modified
        Console.WriteLine("Input an unsigned integer:");
        double digit = double.Parse(Console.ReadLine());
        double digit1 = Math.Ceiling(digit);
        bool checkNumber = (digit == digit1) && (digit >= 0); // check if the 1st input digit is: 1. Intiger; 2. Positive 
        while (checkNumber == false) // cycle which will check each input digit after the first one which is wrong, until a correct digit is input
        {
            Console.Clear();
            Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number:");
            digit = double.Parse(Console.ReadLine());
            digit1 = Math.Ceiling(digit);
            checkNumber = (digit == digit1) && (digit >= 0); // check if the next input digit is: 1. Intiger; 2. Positive 
        }

        long n = Convert.ToInt64(digit);         // the input number number
        Console.WriteLine("The input value is:\n{0}\nThe input value in duoble is:\n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        Console.WriteLine("Input value for \"p\"");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Input value for \"q\"");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Input value for \"k\"");
        int k = int.Parse(Console.ReadLine());
        int j = p;
        long result = n;
        long mask;
        if (p < 0 || q < 0 || p + k > 32 || q + k > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (p + k >= q || q + k >= p)
        {
            Console.WriteLine("Overlapping");
        }
        else if ((p + k - 1) < q || (q + k - 1) < p)
        {
            for (int i = p; i <= ((j + k) - 1); i++)
            {
                int maskp = 1 << p;
                long bitp = (n & maskp) >> p;
                int maskq = 1 << q;
                long bitq = (n & maskq) >> q;
                if (bitp != bitq)
                {
                    if (bitp == 1 && bitq == 0)
                    {
                        mask = ~(1 << p);
                        result = result & mask;
                        mask = 1 << q;
                        result = result | mask;
                    }
                    else
                    {
                        mask = 1 << p;
                        result = result | mask;
                        mask = ~(1 << q);
                        result = result & mask;
                    }
                    Console.WriteLine("Result is {0}", result);
                    Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                }
                p++;
                q++;
            }
        }
    }
}

