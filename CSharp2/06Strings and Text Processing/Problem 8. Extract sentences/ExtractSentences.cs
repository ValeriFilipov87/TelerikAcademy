using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Extract_sentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            string[] text = sentence.Split('.').Select(x => x.Trim()).ToArray();
            char[] separators = sentence.Where(x => !char.IsLetter(x)).Distinct().ToArray();

            foreach (string item in text)
            {
                string[] sentenceWords = item.Split(separators).ToArray();

                for (int i = 0; i < sentenceWords.Length; i++)
                {
                    if (sentenceWords[i] == word)
                    {
                        string temp = item + ". ";
                        result.Append(temp);
                        break;
                    }
                }
            }

            Console.WriteLine(result.ToString().Trim());

        }
    }
}
