/*  Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation 
(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
output

2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds
Note: You may use the suit symbols instead of text.
*/

using System;

class PrintDeckOfCards
{
    public static string[] cardColour = new string[] { "spades", "clubs", "hearts", "diamonds" };
    public static string[] cardValue = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
    static void Main()
    {
        string input = Console.ReadLine();
        int n = new int();
        switch (input)
        {
            case "2": n = 2; break;
            case "3": n = 3; break;
            case "4": n = 4; break;
            case "5": n = 5; break;
            case "6": n = 6; break;
            case "7": n = 7; break;
            case "8": n = 8; break;
            case "9": n = 9; break;
            case "10": n = 10; break;
            case "J": n = 11; break;
            case "Q": n = 12; break;
            case "K": n = 13; break;
            case "A": n = 14; break;
        }

        for (int value = 0; value < n - 1; value++)
        {
            for (int colour = 0; colour < cardColour.Length; colour++)
            {
                Console.Write(cardValue[value]);
                Console.Write(" of ");
                Console.Write(cardColour[colour]);
                if (colour != cardColour.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

