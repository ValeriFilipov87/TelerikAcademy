using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15_2.Replace_tags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string startTag = @"<a ";
            string endTag = @"</a>";
            string[] input = Console.ReadLine().Split(new[] { startTag, endTag }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string result = "";

            for (int index = 0; index < input.Length; index++)
            {
                if (input[index].IndexOf("href=") == 0)
                {
                    string url = GetUrl(input[index]);
                    string label = GetLabel(input[index]);
                    Console.Write("[{0}] ({1})", label, url);
                }
                else
                {
                    Console.Write(input[index]);
                }
            }
            Console.WriteLine(result);
        }

        private static string GetLabel(string label)
        {
            int left = label.IndexOf(">");
            int right = label.IndexOf("<", left + 1);

            return label.Substring(left + 1);
        }

        private static string GetUrl(string url)
        {
            int left = url.IndexOf("\"");
            int right = url.IndexOf("\"", left + 1);

            return url.Substring(left + 1, right - left - 1);
        }
    }
}
