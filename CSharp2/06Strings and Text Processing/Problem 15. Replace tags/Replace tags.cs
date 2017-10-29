using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string tempImput = input;
            string startTag = "<a href=\"";
            string middleTag = "\">";
            string endTag = "</a>";

            do
            {
                string address = tempImput.Substring(tempImput.IndexOf(startTag) + startTag.Length, tempImput.IndexOf(middleTag) - tempImput.IndexOf(startTag) - startTag.Length);
                string text = tempImput.Substring(tempImput.IndexOf(middleTag) + middleTag.Length, tempImput.IndexOf(endTag) - tempImput.IndexOf(middleTag) - middleTag.Length);
                tempImput = tempImput.Substring(tempImput.IndexOf(endTag) + endTag.Length);
                input = input.Replace(startTag + address + middleTag + text + endTag, "[" + text + "]" + "(" + address + ")");
            } while (tempImput.IndexOf(endTag) != -1);

            Console.WriteLine(input);
        }
    }
}
