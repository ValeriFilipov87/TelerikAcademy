using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SortByStringLength
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();
            int[] lengths = new int[inputArray.Length];
            string[] result = new string[inputArray.Length];
            for (int i = 0; i < lengths.Length; i++)
            {
                lengths[i] = inputArray[i].Length;
            }
            Array.Sort(lengths);
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < lengths.Length; j++)
                {
                    if (lengths[j] == inputArray[i].Length)
                    {
                        if (result[j] == null)
                        {
                            result[j] = inputArray[i];
                            break;
                        }
                        else
                        {
                            result[j + 1] = inputArray[i];
                            break;
                        }

                    }
                }
            }
            Console.WriteLine("{0}", string.Join(" ", result));            
        }
    }
}
