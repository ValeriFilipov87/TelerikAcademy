using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4.Sub_string_in_text
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            ////string pattern = Console.ReadLine();
            ////string input = Console.ReadLine();
            ////input = input.ToLower();
            ////int count = 0;
            ////int result = CountPattern(pattern, input, count);
            ////Console.WriteLine(result);

            string pattern = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            int curIndex = input.IndexOf(pattern);
            int counter = 0;

            while (curIndex >= 0)
            {
                counter++;
                curIndex = input.IndexOf(pattern, ++curIndex);
            }

            Console.WriteLine(counter);

        }

        //private static int CountPattern(string pattern, string input, int patternCount)
        //{
        //    if (!input.Contains(pattern))
        //    {
        //        return patternCount;
        //    }
        //    else
        //    {
        //        int index = input.IndexOf(pattern);
        //        input = input.Remove(index, pattern.Length);
        //        patternCount = CountPattern(pattern, input, patternCount + 1);
        //    }
        //    return patternCount;
        //}
    }
}
