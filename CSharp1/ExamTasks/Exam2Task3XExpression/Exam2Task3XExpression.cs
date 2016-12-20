using System;

class Exam2Task3XExpression
{
    static void Main()
    {
        string input = Console.ReadLine();
        int digit = new int();
        int bracketDigit = new int();
        char sign = '+';
        char bracketSign = '+';
        double result = new double();
        double bracketResult = new double();
        bool isInBracket = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                isInBracket = true;
                continue;
            }
            if (input[i] == ')')
            {
                isInBracket = false;
                switch (sign)
                {
                    case '+': result += bracketResult; break;
                    case '-': result -= bracketResult; break;
                    case '/': result = result / bracketResult; break;
                    case '*': result *= bracketResult; break;
                }
                bracketResult = 0;
                bracketSign = '+';
                continue;
            }
            if (isInBracket == true)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '/' || input[i] == '*')
                {
                    bracketSign = input[i];
                }
                if (Char.IsDigit(input[i]))
                {
                    bracketDigit = Convert.ToInt32(input[i]) - '0';
                    switch (bracketSign)
                    {
                        case '+': bracketResult += bracketDigit; break;
                        case '-': bracketResult -= bracketDigit; break;
                        case '/': bracketResult = bracketResult / bracketDigit; break;
                        case '*': bracketResult *= bracketDigit; break;
                    }
                }
                continue;
            }

            if (input[i] == '+' || input[i] == '-' || input[i] == '/' || input[i] == '*')
            {
                sign = input[i];
            }
            if (Char.IsDigit(input[i]))
            {
                digit = Convert.ToInt32(input[i]) - '0';
                switch (sign)
                {
                    case '+': result += digit; break;
                    case '-': result -= digit; break;
                    case '/': result = result / digit; break;
                    case '*': result *= digit; break;
                }
            }
            if (input[i] == '=')
            {
                break;
            }
        }
        Console.WriteLine("{0:F2}", result);
    }
}

