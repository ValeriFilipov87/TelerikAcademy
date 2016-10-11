namespace TEST_Side
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var cards = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            if (cards.Contains(input))
            {
                Console.WriteLine("FAK YEAH {0}", input);
            }
            else
            {
                Console.WriteLine("Try again, bitch!");
            }
        }
    }
}