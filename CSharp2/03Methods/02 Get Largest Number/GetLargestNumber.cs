using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Get_Largest_Number
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ').ToArray();
            int biggestNumber = int.MinValue;
            int currentMax = new int();
            for (int i = 0; i < splitInput.Length - 1; i++)
            {
                currentMax = GetMax(int.Parse(splitInput[i]), int.Parse(splitInput[i + 1]));
                if (currentMax > biggestNumber)
                {
                    biggestNumber = currentMax;
                }
            }         
            Console.WriteLine(biggestNumber);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int max = firstNumber;
            if (secondNumber > firstNumber)
            {
                max = secondNumber;
            }
            return max;
        }
    }
}
