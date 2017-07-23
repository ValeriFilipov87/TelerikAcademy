using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Parse_tags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string startTag = "<upcase>";
            string endTag = "</upcase>";
            StringBuilder result = new StringBuilder();
            string input = Console.ReadLine();
            string toUpper = "";
            
            int indexEnd = input.IndexOf(endTag);

            while (indexEnd >= 0)
            {
                result.Append(input.Substring(0, input.IndexOf(startTag)));
                input = input.Remove(0, input.IndexOf(startTag) + startTag.Length);
                toUpper = input.Substring(0, input.IndexOf(endTag)).ToUpper().ToString();
                result.Append(toUpper);
                input = input.Remove(0, input.IndexOf(endTag) + endTag.Length);
                indexEnd = input.IndexOf(endTag);
            }
            result.Append(input);
            Console.WriteLine(result.ToString());
        }
    }
}
