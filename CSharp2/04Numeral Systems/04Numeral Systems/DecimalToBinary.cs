using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04Numeral_Systems
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {            
            BigInteger digit = BigInteger.Parse(Console.ReadLine());
            string result = DecimalToBinaryConvert(digit);            
            Console.WriteLine(result);
        }

        private static string DecimalToBinaryConvert(BigInteger digit)
        {
            string tempResult = "";
            while (digit != 0)
            {
                if (digit % 2 == 0)
                {
                    tempResult += string.Join("", 0);
                }
                else
                {
                    tempResult += string.Join("", 1);
                }
                digit = digit / 2;
            }
            tempResult = StringReverse(tempResult);
            return tempResult;
        }

        private static string StringReverse(string result)
        {
            char[] temp = result.ToArray();
            Array.Reverse(temp);
            return new string(temp);
        }
    }
}
