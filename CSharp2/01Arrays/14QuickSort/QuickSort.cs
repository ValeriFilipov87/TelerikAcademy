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

            int low = 0;
            int high = digits.Length;

            result = QuickSortAlg(digits, low, high);
            PrintResult(result);
        }

        private static int[] QuickSortAlg(int[] array, int min, int max)
        {
            int pivotLocation = new int();
            if (min < max)
            {
                pivotLocation = Partition(array, min, max);
                QuickSortAlg(array, min, pivotLocation);
                QuickSortAlg(array, pivotLocation + 1, max);
            }
            return array;
        }

        private static int Partition(int[] array, int min, int max)
        {
            int pivot = array[min];
            int leftwall = min;
            for (int i = min + 1; i < max; i++)
            {
                if (array[i] < pivot)
                {
                    int temp = new int();
                    temp = array[i];
                    array[i] = array[leftwall];
                    array[leftwall] = temp;
                    leftwall++;
                }
            }
            int swap = new int();
            swap = pivot;
            pivot = array[leftwall];
            array[leftwall] = swap;

            return leftwall;
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
