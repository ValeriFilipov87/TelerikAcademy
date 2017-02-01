using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            int[] result = new int[digits.Length];

            result = MergeSorting(digits);
            PrintResult(result);
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

        private static int[] MergeSorting(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int[] a1 = ArrayAssign(array, 1);
            int[] a2 = ArrayAssign(array, 2);

            a1 = MergeSorting(a1);
            a2 = MergeSorting(a2);
            return MergeSimple(a1, a2);
        }

        private static int[] MergeSimple(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length + array2.Length];
            List<int> a1 = array1.ToList();
            List<int> a2 = array2.ToList();
            List<int> a3 = new List<int>();
            int index = 0;
            while (a1.Any() && a2.Any())
            {
                if (a1[index] > a2[index])
                {
                    a3.Add(a2[index]);
                    a2.Remove(a2[index]);
                }
                else
                {
                    a3.Add(a1[index]);
                    a1.Remove(a1[index]);
                }
            }
            while (a1.Any())
            {
                a3.Add(a1[index]);
                a1.Remove(a1[index]);
            }
            while (a2.Any())
            {
                a3.Add(a2[index]);
                a2.Remove(a2[index]);
            }
            array3 = a3.ToArray();
            return array3;
        }

        private static int[] ArrayAssign(int[] array, int a)
        {
            int[] sequence = new int[array.Length / 2];
            int start = 0;
            if (a == 1)
            {
                start = 0;
            }
            else
            {
                start = (array.Length / 2);

            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                sequence[i] = array[start];
                start++;
            }
            return sequence;
        }
    }
}
