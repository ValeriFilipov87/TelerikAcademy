/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int element = int.Parse(Console.ReadLine());
            int[] digits = input.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            Array.Sort(digits);
            int left = 0;
            int right = digits.Length - 1;
            int middle = (digits.Length - 1) / 2;
            bool isElementFound = false;
            while (!isElementFound)
            {
                if (element > digits[middle])
                {
                    left = middle + 1;
                    middle = (right + left) / 2;
                    if (element == digits[middle])
                    {
                        isElementFound = true;
                    }
                }
                if (element < digits[middle])
                {
                    right = middle - 1;
                    middle = (right + left) / 2;
                    if (element == digits[middle])
                    {
                        isElementFound = true;
                    }
                }
                if (element == digits[middle])
                {
                    isElementFound = true;
                }
            }
            
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
            Console.WriteLine(middle);
            Console.WriteLine();
        }
    }
}
