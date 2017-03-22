using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02_Binary_To_Decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();
            BigInteger result = 0;
            for (int i = 0; i < digit.Length; i++)
            {
                result += (BigInteger)((digit[i] - '0') * Math.Pow(2, digit.Length - 1 - i));
            }
            Console.WriteLine(result);
        }
    }
}
