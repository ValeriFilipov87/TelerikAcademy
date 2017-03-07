using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sorting_Array
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] digits = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            digits = SortArray(digits);
            string print = string.Join(" ", digits);
            Console.WriteLine(print);
        }

        private static int[] SortArray(int[] digits)
        {
            int maxElement = new int();
            for (int currentElement = digits.Length - 1; currentElement >= 0; currentElement--)
            {
                maxElement = GetMaxElement(digits, 0, currentElement);
                if (currentElement != maxElement)
                {
                    digits[currentElement] = digits[currentElement] + digits[maxElement];
                    digits[maxElement] = digits[currentElement] - digits[maxElement];
                    digits[currentElement] = digits[currentElement] - digits[maxElement];
                }
            }

            return digits;
        }

        private static int GetMaxElement(int[] digits, int startIndex, int stopIndex)
        {
            int maxNumber = int.MinValue;
            int maxElement = -1;
            for (int currentIndex = startIndex; currentIndex <= stopIndex; currentIndex++)
            {
                if (digits[currentIndex] > maxNumber)
                {
                    maxNumber = digits[currentIndex];
                    maxElement = currentIndex;
                }
            }
            return maxElement;
        }
    }
}
