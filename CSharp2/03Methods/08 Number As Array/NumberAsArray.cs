using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Number_As_Array
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            int[] arrayLength = ReadFromConsole();
            int[] firstDigit = ReadFromConsole();
            int[] secondDigit = ReadFromConsole();
            int[] result = GetSum(firstDigit, secondDigit, arrayLength);
            PrintArray(result);
        }

        private static void PrintArray(int[] result)
        {
            string print = string.Join(" ", result);
            Console.WriteLine(print);
        }

        private static int[] GetSum(int[] firstDigit, int[] secondDigit, int[] arrayLength)
        {
            int addition = new int();
            int currentSum = new int();
            int[] result = new int[arrayLength.Max()];

            for (int i = 0; i < arrayLength.Min(); i++)
            {
                currentSum = 0;
                currentSum = firstDigit[i] + secondDigit[i] + addition;
                addition = 0;

                if (currentSum > 9)
                {
                    addition = 1;
                    currentSum %= 10;
                }
                result[i] = currentSum;
            }
            result = AuxiliaryFunction(result, firstDigit, secondDigit, addition, arrayLength);           
            return result;
        }

        private static int[] AuxiliaryFunction(int[] result, int[] firstDigit, int[] secondDigit, int addition, int[] arrayLength)
        {
            int currentSum = new int();
            for (int i = arrayLength.Min(); i < arrayLength.Max(); i++)
            {
                currentSum = 0;
                if (arrayLength[0] > arrayLength[1])
                {
                    currentSum = firstDigit[i] + addition;
                }
                else
                {
                    currentSum = secondDigit[i] + addition;
                }                
                addition = 0;
                if (currentSum > 9)
                {
                    addition = 1;
                    currentSum %= 10;
                }
                result[i] = currentSum;
            }
            if (addition == 1)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = 1;
            }
            return result;
        }

        private static int[] ReadFromConsole()
        {
            string input = Console.ReadLine();
            int[] data = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            return data;
        }
    }
}
