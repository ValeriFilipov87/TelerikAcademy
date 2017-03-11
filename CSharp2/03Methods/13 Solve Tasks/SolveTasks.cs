using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _13_Solve_Tasks
{
    class SolveTasks
    {
        static public string command = "";
        static void Main(string[] args)
        {
            bool taskIsRunning = true;
            while (taskIsRunning)
            {
                PrintMenu();
                command = Console.ReadLine();
                Menu(command);                
            }            
        }

        private static bool Menu(string command)
        {
            bool task = true;
            switch (command)
            {
                case "1": SubMenuOne(); break;
                case "2": SubMenuTwo(); break;
                case "3": SubMenuThree(); break;
                case "4": task = Exit(task); break;
            }
            return task;
        }

        private static void SubMenuOne()
        {
            bool isSubmenuOn = true;
            do
            {
                ReverseDigits();
                isSubmenuOn = Choice(isSubmenuOn);
            } while (isSubmenuOn);
        }

        private static void SubMenuTwo()
        {
            bool isSubmenuOn = true;
            do
            {
                AverageOfSequence();
                isSubmenuOn = Choice(isSubmenuOn);
            } while (isSubmenuOn);
        }

        private static void SubMenuThree()
        {
            bool isSubmenuOn = true;
            do
            {
                SolveEquation();
                isSubmenuOn = Choice(isSubmenuOn);
            } while (isSubmenuOn);
        }

        private static bool Choice(bool isSubmenuOn)
        {
            bool isWrong = true;
            while (isWrong)
            {
                Console.WriteLine();
                Console.WriteLine("To reverse another digit type \"restart\"");
                Console.WriteLine("For return to main menu type \"return\"");
                Console.WriteLine("To exit from the program type \"exit\"");
                string input = Console.ReadLine();
                Console.Clear();
                if (input == "restart")
                {
                    isWrong = false;
                    return true;                    
                }
                else if (input == "return")
                {
                    isWrong = false;
                    return false;
                }
                else if (input == "exit")
                {
                    isWrong = Exit(isWrong);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong input! Try again!");
                    Thread.Sleep(1000);
                }
            }
            return false;
        }

        private static void ReverseDigits()
        {
            Console.Clear();
            Console.Write("Please input your digit: ");
            string[] digit = UserInput();
            Array.Reverse(digit);
            PrintString(digit);
        }

        private static void AverageOfSequence()
        {
            Console.Clear();
            Console.Write("Please input your sequence: ");
            string[] sequence = UserInput();
            int[] array = sequence.Select(x => int.Parse(x)).ToArray();
            double average = array.Average();
            Console.WriteLine("Answer: {0}", average);
        }

        private static void SolveEquation()
        {
            Console.Clear();
            Console.Write("Please input values for \"a\" and  \"b\" in \"a * x + b = 0\", separated by space: ");
            string[] sequence = UserInput();
            decimal[] array = sequence.Select(x => decimal.Parse(x)).ToArray();
            decimal result = (-1) * array[1] / array[0];
            Console.WriteLine("Answer: {0}", result);
        }

        private static void PrintString(string[] digit)
        {
            string print = string.Join("", digit);
            Console.WriteLine("Answer: {0}", print);
        }

        private static string[] UserInput()
        {
            string digit = Console.ReadLine();

            string[] input = digit.Split(' ').ToArray();
            if (input.Length == 1)
            {
                digit = Check(digit);
                input = digit.Split(' ').ToArray();
                input = SeparateDigits(input);
                return input;
            }
            else
            {
                return input;
            }
        }

        private static string Check(string digit)
        {
            decimal check = decimal.Parse(digit);
            bool isWrongDigit = true;
            if (check > 0)
            {
                return digit;
            }
            else
            {
                while (isWrongDigit)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input! Insert positive digit: ");
                    digit = Console.ReadLine();
                    check = decimal.Parse(digit);
                    if (check > 0)
                    {
                        isWrongDigit = false;
                    }
                }
                return digit;
            }
        }

        private static string[] SeparateDigits(string[] input)
        {
            string[] result = new string[input[0].Length];
            for (int i = 0; i < input[0].Length; i++)
            {
                result[i] = input[0][i].ToString();
            }
            return result;
        }

        private static bool Exit(bool statusOfTask)
        {
            bool isGoing = true;
            while (isGoing)
            {
                Console.Clear();
                Console.WriteLine("Are you sure?");
                Console.WriteLine("For exit press: \"Y\"");
                Console.WriteLine("For return to main menu press: \"N\"");
                string input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    Environment.Exit(0);
                }
                else if (input == "N" || input == "n")
                {
                    isGoing = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong Input! Please try again!");
                    Thread.Sleep(1000);
                }
            }
            return false;
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Please input your choice from 1 to 4");
            Console.WriteLine("1. Reverses the digits of a number.");
            Console.WriteLine("2. Calculates the average of a sequence of integers.");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            Console.WriteLine("4. Exit");
            Console.Write("Please input your choice: ");
        }
    }
}
