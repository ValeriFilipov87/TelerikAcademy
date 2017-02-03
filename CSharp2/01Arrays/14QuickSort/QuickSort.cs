using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            int[] result = new int[digits.Length];

            int left = 0;
            int right = digits.Length - 1;

            result = QuickSortAlg(digits, left, right);
            PrintResult(result);
        }

        private static int[] QuickSortAlg(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = array[(left + right) / 2];
                int pivotLocation = Partition(array, left, right, pivot);
                QuickSortAlg(array, left, pivotLocation-1);
                QuickSortAlg(array, pivotLocation, right);
            }
            return array;
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {

            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int swap = 0;
                    swap = array[left];
                    array[left] = array[right];
                    array[right] = swap;
                    left++;
                    right--;
                }
            }
            return left;
        }

        private static void PrintResult(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i != result.Length - 1)
                {
                    Console.Write(',');
                }
            }
            Console.WriteLine();
        }
    }
}
