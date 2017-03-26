using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_Decimal_To_Hexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            BigInteger inputDigit = BigInteger.Parse(Console.ReadLine());
            string result = "";
            BigInteger temp = new BigInteger();
            char[] map = { 'A', 'B', 'C', 'D', 'E', 'F' };

            while (inputDigit != 0)
            {
                temp = inputDigit % 16;
                if (temp < 10)
                {
                    result += string.Join("", temp);
                }
                else
                {
                    result += string.Join("", map[(int)temp - 10]);
                }
                inputDigit = inputDigit / 16;
            }
            result = StringReverse(result);
            Console.WriteLine(result);
        }

        private static string StringReverse(string result)
        {
            char[] temp = result.ToArray();
            Array.Reverse(temp);
            return new string(temp);
        }
    }
}
