using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_23.Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countOfRepeatedChars = 0;
            string result = input;

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    result = result.Remove(countOfRepeatedChars,1);
                }
                else
                {
                    countOfRepeatedChars++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
