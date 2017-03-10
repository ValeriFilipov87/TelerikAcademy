using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__N_Factorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] digit = { 1 };
            int[] result = CalculateFactorial(N, digit);
            Array.Reverse(result);
            PrintResult(result);
        }       
        private static void PrintResult(int[] result)
        {
            string print = string.Join("", result);
            Console.WriteLine(print);
        }
        private static int[] CalculateFactorial(int n, int[] digit)
        {
            int[] result = { 1 };
            int tempIndex = new int();
            if (n == 1)
            {
                return result;
            }
            for (int index = 1; index <= n; index++)
            {
                if (index < 10)
                {
                    result = MultplicationWithOneDigit(result, index);
                }
                else
                {
                    int[] firstDigit = new int[result.Length];
                    int[] secondDigit = new int[result.Length];
                    Array.Copy(result, firstDigit, result.Length);
                    Array.Copy(result, secondDigit, result.Length);
                    secondDigit = ExtendArray(secondDigit);
                    tempIndex = index % 10;
                    firstDigit = MultplicationWithOneDigit(firstDigit, tempIndex);
                    tempIndex = index / 10;
                    secondDigit = MultplicationWithOneDigit(secondDigit, tempIndex);
                    int[] arrayLength = { firstDigit.Length, secondDigit.Length };
                    result = GetSum(firstDigit, secondDigit, arrayLength);
                }
            }
            return result;
        }
        private static int[] ExtendArray(int[] secondDigit)
        {
            int[] tempArray = new int[secondDigit.Length + 1];
            for (int i = 0; i < secondDigit.Length; i++)
            {
                tempArray[i + 1] = secondDigit[i];
            }
            return tempArray;
        }
        private static int[] MultplicationWithOneDigit(int[] digit, int index)
        {
            int[] result = new int[digit.Length];
            int product = new int();
            int addition = new int();
            for (int i = 0; i < result.Length; i++)
            {
                product = 0;
                product = (digit[i] * index) + addition;
                addition = 0;
                if (product > 9)
                {
                    addition = product / 10;
                    product = product % 10;
                }
                if (i == result.Length - 1 && addition != 0)
                {
                    Array.Resize(ref result, result.Length + 1);
                    Array.Resize(ref digit, digit.Length + 1);
                }
                result[i] = product;
            }
            return result;
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
    }
}
