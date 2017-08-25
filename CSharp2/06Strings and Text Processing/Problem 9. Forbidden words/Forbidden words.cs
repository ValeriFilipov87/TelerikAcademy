using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Forbidden_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string forbidenWordsInput = Console.ReadLine();
            string[] forbidenWords = forbidenWordsInput.Split(',').Select(x => x.Trim()).ToArray();

            string textInput = Console.ReadLine();
            string[] words = textInput.Split(' ').ToArray();

            char[] separators = textInput.Where(x => !char.IsLetterOrDigit(x)).Distinct().ToArray();

            List<int> positions = new List<int>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string temp = "";
                temp = words[i];
                words[i] = words[i].TrimEnd(separators);
                if (temp != words[i])
                {
                    positions.Add(i);
                }
            }


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < forbidenWords.Length; j++)
                {
                    if (words[i] == forbidenWords[j])
                    {
                        words[i] = words[i].Replace(words[i], new string('*', forbidenWords[j].Length));
                    }
                }
            }
            int currentPosition = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (i == positions[currentPosition])
                {
                    words[i] = words[i] + ".";
                    currentPosition++;
                }
            }

            foreach (var item in words)
            {
                result.Append(item);
                result.Append(" ");
            }
            string print = result.ToString();
            print = print.Trim();
            Console.WriteLine(print);
        }
    }
}
