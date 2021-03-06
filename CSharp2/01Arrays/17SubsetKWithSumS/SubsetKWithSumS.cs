﻿using System;
using System.Collections.Generic;
using System.Linq;

/*Problem 17.* Subset K with sum S

Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
Find in the array a subset of K elements that have sum S or indicate about its absence.
*/
namespace _17SubsetKWithSumS
{
    class SubsetKWithSumS
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number N (size of array): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a number K (size of subset): ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter a searched Sum: ");
            int sum = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("   {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            PrintAllSubsetsWithGivenSum(numbers, sum, k);

        }

        static void PrintAllSubsetsWithGivenSum(int[] numbers, int searchedSum, int sizeSubset)
        {
            Console.WriteLine("\nAll subsets with sum = {0}", searchedSum);

            int subsetsCount = (int)(Math.Pow(2, numbers.Length) - 1); // Number of subsets
            List<int> subset = new List<int>();
            bool isFoundSubset = false;

            for (int i = 1; i <= subsetsCount; i++) // go through each sequence
            {
                subset.Clear();
                for (int j = 0; j < numbers.Length; j++) 
                {
                    if (((i >> j) & 1) == 1)
                    {
                        subset.Add(numbers[j]);
                    }
                }
                if (subset.Sum() == searchedSum && subset.Count == sizeSubset)
                {
                    isFoundSubset = true;
                    Console.WriteLine("Subset #: {0}", i);
                    Console.WriteLine(string.Join(" ", subset)); // Print subset
                }
            }

            Console.WriteLine(!isFoundSubset ? "- There are no subsets with Sum " + searchedSum + "\n" : "");
        }
    }
}
