using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Word_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dictionary = new string[,] 
            { 
                   { ".NET", "platform for applications from Microsoft" },
                   { "CLR", "managed execution environment for .NET" },
                   { "namespace", "hierarchical organization of classes" }
            };  
                      
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < dictionary[i,0].Length; i++)
            {
                if (input == dictionary[i,0])
                {
                    result = dictionary[i,1];
                    break;
                }                
            }
            if (result == "")
            {
                Console.WriteLine("The input word does not exist in the dictionary");
            }
            else
            {
                Console.WriteLine(result);
            }            
        }
    }
}
