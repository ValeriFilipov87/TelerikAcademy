using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Reverse_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] signs = { ',', '.', '!', '?', ' '};
            string[] temp = input.Split(' ').Select(x => x.Trim()).ToArray();

            string[] words = input.Split(signs).Select(x => x.Trim()).ToArray();
            words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Array.Reverse(words);

            for (int j = 0; j < signs.Length-1; j++)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    int index = temp[i].IndexOf(signs[j]);
                    if (index > 0)
                    {
                        words[i] += signs[j];
                        index = -1;
                    }
                }
            }          
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }
    }
}
