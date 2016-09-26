/*  We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. */

using System;
class Program
{
    static void Main()
    {
         //insert the integer number which should be modified
         Console.WriteLine("Input an unsigned integer:");
         double digit = double.Parse(Console.ReadLine());
         double digit1 = Math.Ceiling(digit);
         bool checkNumber = (digit == digit1) && (digit >= 0); // check if the 1st input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
         while (checkNumber == false) // cycle which will check each input digit after the first one which is wrong, until a correct digit is input
         {
             Console.Clear();
             Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number:");
             digit = double.Parse(Console.ReadLine());
             digit1 = Math.Ceiling(digit);
             checkNumber = (digit == digit1) && (digit >= 0); // check if the next input digit is: 1. Intiger; 2. Positive 3. Lesser from or even to 100
         }

         // insert the position which should modified
         Console.WriteLine("Input an unsigned integer for the position:");
         double position = double.Parse(Console.ReadLine());
         double position1 = Math.Ceiling(position);
         bool checkPosition = (position == position1) && (digit >= 0) && (position <= 32);
         while (checkPosition == false)
         {
             Console.Clear();
             Console.WriteLine("The input number is not a unsigned intiger! Please write a unsigned intiger number for the position:");
             position = double.Parse(Console.ReadLine());
             position1 = Math.Ceiling(position);
             checkPosition = (position == position1) && (digit >= 0) && (position <= 32);
         }

         // insert the value to which the integer number should be modified
         Console.WriteLine("Input a value 0 or 1:");
         double newValue = double.Parse(Console.ReadLine());
         bool checkNewValue = (newValue == 0) || (newValue == 1);
         while (checkPosition == false)
         {
             Console.Clear();
             Console.WriteLine("The input number is not a 0 or 1! Please write a 0 or 1:");
             newValue = double.Parse(Console.ReadLine());
             checkNewValue = (newValue == 0) || (newValue == 1);
         }

         int n = Convert.ToInt16(digit);         // number
         int p = Convert.ToInt16(position);      // position
         int v = Convert.ToInt16(newValue);      // 0 | 1

         // check a bit in a given position
         int mask = 1 << p;
         int nAndMask = n & mask;
         int bit = nAndMask >> p;
         bool check = bit == v;

         //Print the result if the value of the checked bit is the same with the one that we want to make it to:
         if (check)
         {
             Console.WriteLine("No Change!");
             Console.WriteLine("The input value is:{0}\nThe input value in duoble is:{1}\nThe new value is:{2}\nThe new value in double is:{3}", n, Convert.ToString(n, 2).PadLeft(16, '0'), n, Convert.ToString(n, 2).PadLeft(16, '0'));
         }
         else
         {
             if (bit == 1)
             {
                 mask = ~(1 << p);
                 int result = n & mask;
                 Console.WriteLine("The input value is:{0}\nThe input value in duoble is:{1}\nThe new value is:{2}\nThe new value in double is:{3}", n, Convert.ToString(n, 2).PadLeft(16, '0'), result, Convert.ToString(result, 2).PadLeft(16, '0'));
             }
             else
             {
                 mask = 1 << p;
                 int result = n | mask;
                 Console.WriteLine("The input value is:{0}\nThe input value in duoble is:{1}\nThe new value is:{2}\nThe new value in double is:{3}", n, Convert.ToString(n, 2).PadLeft(16, '0'), result, Convert.ToString(result, 2).PadLeft(16, '0'));
             } 
         }             
    }
}

