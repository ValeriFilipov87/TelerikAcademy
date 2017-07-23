using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Reverse_string
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = StringReverse(input);
            Console.WriteLine(input);
        }

        private static string StringReverse(string input)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = input.Length-1; i >= 0; i--)
            {
                temp.Append(input[i]);
            }
            input = temp.ToString();
            return input;
        }
    }
}
