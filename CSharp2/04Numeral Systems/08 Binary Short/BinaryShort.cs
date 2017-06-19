using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Binary_Short
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            short digit = short.Parse(Console.ReadLine());
            if (digit>=0)
            {
                Console.WriteLine(ComvertToBinary(digit).PadLeft(16, '0'));
            }
            else
            {
                short negativeDigit = (short)(Math.Pow(2, 15) + digit);
                Console.WriteLine(ComvertToBinary(negativeDigit).PadLeft(15, '0').PadLeft(16,'1'));
            }
        }

        private static string ComvertToBinary(short digit)
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
                digit = (short)(digit / 2);
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
