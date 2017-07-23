using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Arithmetical_expressions
{
    class ArithmeticalExpressions
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ", string.Empty);

            char[] firstPriority = { '+', '-', '*', '/', '(', ')' };
            string[] specialFunction = { "ln", "sqrt", "pow" };

            Stack<string> tempStack = new Stack<string>();
            Stack<string> signStack = new Stack<string>();

            bool isDecimalDigit = false;
            foreach (char c in input)
            {
                if (c >= '0' && c <= '9')
                {
                    if (isDecimalDigit)
                    {
                        string temp = tempStack.Pop() + c.ToString();
                        tempStack.Push(temp);
                        continue;
                    }
                    tempStack.Push(c.ToString());
                    continue;
                }
                if (c == '.')
                {
                    isDecimalDigit = true;
                    string temp = tempStack.Pop() + ".";
                    tempStack.Push(temp);
                    continue;
                }

                if (signStack.Count == 0)
                {
                    isDecimalDigit = false;
                    signStack.Push(c.ToString());
                    continue;
                }
            }
            foreach (var item in signStack)
            {
                string temp = signStack.Pop();
                tempStack.Push(temp);
            }
        }
    }
}
