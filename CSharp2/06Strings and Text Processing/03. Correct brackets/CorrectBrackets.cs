using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> bracketStatus = new Stack<string>();
            string status = "Correct";
            int countOpen = 0;
            int countClosed = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    countOpen++;
                    bracketStatus.Push("Open");
                }
                if (input[i] == ')')
                {
                    countClosed++;
                    if (bracketStatus.Count > 0)
                    {
                        bracketStatus.Pop();
                    }
                    else
                    {
                        status = "Incorrect";
                        break;
                    }
                }
            }
            if (countOpen != countClosed)
            {
                status = "Incorrect";
            }
            Console.WriteLine(status);
        }
    }
}
