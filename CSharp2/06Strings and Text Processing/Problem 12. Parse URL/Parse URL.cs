using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string protocol = Extract(url, url[0].ToString(), ":");
            string server = Extract(url, "//", "/");
            string resource = Extract(url, "/", "");

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }

        private static string Extract(string url, string separator1, string separator2)
        {
            int index1 = url.IndexOf(separator1);

            if (separator1 == "//")
            {
                index1 = index1 + 2;
            }
            else if (separator1 == "/")
            {
                index1 = url.IndexOf(separator1, index1 + 2);
            }
            int index2 = url.IndexOf(separator2, index1);
            if (separator2 == "")
            {
                index2 = url.Length;
            }            
            string result = url.Substring(index1, index2 - index1);
            return result;
        }
    }
}
