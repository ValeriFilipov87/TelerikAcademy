using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Binary_To_Hexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string[] binaryMap = BinaryHexTable(16);

            string input = Console.ReadLine();
            string tempDigit = input;
            string currentFour = "";
            string result = "";
            char[] hexMap = { 'A', 'B', 'C', 'D', 'E', 'F' };
            bool stop = true;
            while ((tempDigit.Length != 0) && stop)
            {
                if (tempDigit.Length - 4 >= 0)
                {
                    for (int i = tempDigit.Length - 1; i >= tempDigit.Length - 4; i--)
                    {
                        currentFour += string.Join("", input[i]);
                    }
                    tempDigit = tempDigit.Substring(0, tempDigit.Length - 4);
                }
                else
                {
                    for (int i = tempDigit.Length - 1; i >= 0; i--)
                    {
                        currentFour += string.Join("", input[i]);
                    }
                    stop = false;
                }
                currentFour = StringReverse(currentFour);
                if (currentFour.Length < 4)
                {
                    currentFour = currentFour.PadLeft(4, '0');
                }
                for (int i = 0; i < binaryMap.Length; i++)
                {
                    if (currentFour == binaryMap[i])
                    {
                        if (i<10)
                        {
                            result += string.Join("", i);
                            break;
                        }
                        else
                        {
                            result += string.Join("", hexMap[i - 10]);
                        }
                    }
                }
                currentFour = "";
            }
            result = StringReverse(result);
            Console.WriteLine(result);
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
