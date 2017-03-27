using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hexadecimal_To_Binary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            string[] binaryMap = BinaryHexTable(16);
            char[] hexMap = { 'A', 'B', 'C', 'D', 'E', 'F' };
            result = ConvertHexToBinary(input, binaryMap, hexMap);            
            Console.WriteLine(result);
        }

        private static string ConvertHexToBinary(string input,string[] binaryMap, char[] hexMap)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] - '0') < 10)
                {
                    result += string.Join("", binaryMap[(input[i] - '0')]);
                }
                else
                {
                    int keyIndex = Array.FindIndex(hexMap, w => w.Equals(input[i])) + 10;
                    result += string.Join("", binaryMap[keyIndex]);
                }
            }
            return result.TrimStart('0');
        }

        private static string[] BinaryHexTable(int length)
        {
            string[] binaryMap = new string[length];
            for (int i = 0; i < binaryMap.Length; i++)
            {
                binaryMap[i] = DecimalToBinary(i);
                if (i < 8)
                {
                    binaryMap[i] = binaryMap[i].PadLeft(4, '0');
                }
            }
            return binaryMap;
        }

        private static string DecimalToBinary(int digit)
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
