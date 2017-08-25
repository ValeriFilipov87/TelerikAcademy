using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            
            foreach (var item in input)
            {
                result.Append(GetEscapeSequence(item));
            }

            string print = result.ToString();
            Console.WriteLine(print);
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
