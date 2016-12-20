using System;

class Program
{
    static void Main()
    {
        string digit = Console.ReadLine();

        int sumEven = new int();
        int sumOdd = new int();
        

        for (int i = 0; i < digit.Length; i++)
        {
            if (char.IsDigit(digit[i]))
            {
                int m = digit[i] - '0';
                if (m % 2 == 0)
                {
                    sumEven += m;
                }
                else
                {
                    sumOdd += m;
                }
            }            
            
        }
        if (sumEven>sumOdd)
        {
            Console.WriteLine("right {0}", sumEven);
        }
        else if (sumEven < sumOdd)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("straight {0}", sumOdd);
        }
    }
}

