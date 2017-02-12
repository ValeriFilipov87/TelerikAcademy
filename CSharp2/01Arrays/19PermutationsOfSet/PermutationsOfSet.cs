using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19PermutationsOfSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            string input = "";          
            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;                 
                input += array[i].ToString();
            }
            var result = Permute(input);
            PrintResult(result);
        }

        private static void PrintResult(List<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> Permute(string input)
        {
            if (input.Length == 1)
            {
                return new List<string>() { input };
            }

            var permutations = new List<string>();

            var toInsert = input[0].ToString();
            foreach (var item in Permute(input.Substring(1)))
            {
                for (int i = 0; i <= item.Length; ++i)
                {
                    string newPermutation = item.Insert(i, toInsert);
                    permutations.Add(newPermutation);
                }
            }

            return permutations;
        }
    }
}
