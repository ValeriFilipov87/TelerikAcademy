using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());
            string[] inputArray = (input.Split(' ').ToArray());
            int[] array = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }
            Array.Sort(array);
            int result = Array.BinarySearch(array, K);
            if (result > 0)
            {
                Console.WriteLine(result);
                Console.WriteLine(array[result]);
            }
            else
            {
                int min = array.Min();
                if (min > K)
                {
                    Console.WriteLine("No such digit in the sequence");
                    return;
                }
                else
                {
                    int currentDigit = K;
                    while (Array.BinarySearch(array, currentDigit) < 0)
                    {
                        currentDigit--;
                        result = Array.BinarySearch(array, currentDigit);
                    }
                }
                Console.WriteLine(result);
                Console.WriteLine(array[result]);
            }
        }
    }
}
