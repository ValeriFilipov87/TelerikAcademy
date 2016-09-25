/*  Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("You must enter a positive intiger number");
        double digit = double.Parse(Console.ReadLine());
        double digit1 = Math.Ceiling(digit);
        bool check = (digit == digit1) && (digit >= 0) && (digit <= 100); // check if the 1st input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100

        while (check == false) // cycle which will check each input digit after the first one which is wrong, until a correct digit is input
        {
            Console.Clear();
            Console.WriteLine("The input number is not a positive intiger! Please write a positive intiger number");
            digit = double.Parse(Console.ReadLine());
            digit1 = Math.Ceiling(digit);
            check = (digit == digit1) && (digit >= 0) && (digit <= 100); // check if the next input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
        }

        bool prime = false;
        for (int i = 2; i <= Math.Sqrt(digit); i++) // algorithm for finding a prime number: Devide the input number on every intiger number <= to the sqrt value of the input number
        {                                           // then compare the remainder with 0
            if (digit % i == 0)
            {
                prime = true;
                break;
            }
        }
        if(prime)
        {
            Console.WriteLine("The digit is not a prime number");
        }
        else
        {
            Console.WriteLine("The digit is a prime number");
        }
    }
}

