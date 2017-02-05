using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number N (size of array): ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("   {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            PrintAllSubsetsWithGivenSum(numbers);

        }

        static void PrintAllSubsetsWithGivenSum(int[] numbers)
        {
            Console.WriteLine("\nThe longest sorted subsets:");

            int subsetsCount = (int)(Math.Pow(2, numbers.Length) - 1); // Number of subsets
            List<int> subset = new List<int>();
            List<int> indexList = new List<int>();
            List<int> subsetToPrint = new List<int>();

            int combination = new int();
            int largestArrayCount = new int();

            bool isFoundSubset = false;

            for (int i = 1; i <= subsetsCount; i++) // go through each sequence
            {
                subset.Clear();
                indexList.Clear();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        subset.Add(numbers[j]);
                        indexList.Add(j);
                    }
                }

                bool isSubsetSorted = isSorted(subset);
                bool isIndexListSorted = isSorted(indexList);

                if (isSubsetSorted && isIndexListSorted)
                {
                    if (subset.Count > largestArrayCount)
                    {
                        largestArrayCount = subset.Count;
                        subsetToPrint.Clear();
                        for (int b = 0; b < subset.Count; b++)
                        {
                            subsetToPrint.Add(subset[b]);
                        }
                        combination = i;
                    }
                    isFoundSubset = true;
                }
            }
            Console.WriteLine("Combination #: {0}", combination);
            Console.WriteLine(string.Join(" ", subsetToPrint));
            Console.WriteLine(!isFoundSubset ? "- There are no such subsets " + "\n" : "");
        }

        private static bool isSorted(List<int> subset)
        {
            bool isSorted = true;
            for (int i = 0; i < subset.Count - 1; i++)
            {
                if (subset[i] > subset[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            return isSorted;
        }
    }
}

