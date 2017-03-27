using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04_Hexadecimal_To_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger result = 0;
            char[] map = { 'A', 'B', 'C', 'D', 'E', 'F' };

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] - '0') < 10)
                {
                    result += (BigInteger)((input[i] - '0') * Math.Pow(16, input.Length - 1 - i));
                }
                else
                {
                    int keyIndex = Array.FindIndex(map, w => w.Equals(input[i])) + 10;
                    result += (BigInteger)((keyIndex) * Math.Pow(16, input.Length - 1 - i));
                }
            }
            Console.WriteLine(result);
        }
    }
}
