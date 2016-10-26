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
    public static int[] cardColour = new int[] { 3, 4, 5, 6 };
    public static string[] cardValue = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
    static void Main()
    {
        for (int i = 0; i < cardValue.Length; i++)
        {
            PrintCards(cardValue[i]);
            Console.WriteLine();
        }


    }

    private static void PrintCards(string cardValue)
    {
        string value = cardValue;
        string concat = " of ";
        for (int i = 0; i < cardColour.Length; i++)
        {
            Console.Write(value + concat + (char)cardColour[i] + " ");
        }

    }
}

