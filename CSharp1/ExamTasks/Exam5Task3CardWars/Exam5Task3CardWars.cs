using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Exam5Task3CardWars
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        BigInteger playerOneScore = 0;
        int playerOneGames = 0;
        BigInteger playerTwoScore = 0;
        int playerTwoGames = 0;

        for (int i = 0; i < N; i++)
        {
            int playerOneRoundScore = 0;
            int playerTwoRoundScore = 0;
            bool hasOneX = false;            
            bool hasTwoX = false;

            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": playerOneRoundScore += 1; break;
                    case "J": playerOneRoundScore += 11; break;
                    case "Q": playerOneRoundScore += 12; break;
                    case "K": playerOneRoundScore += 13; break;
                    case "X": hasOneX = true; break;
                    case "Y": playerOneScore -= 200; break;
                    case "Z": playerOneScore *= 2; break;
                    default: playerOneRoundScore += 12 - int.Parse(card); break;
                }
            }            
            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": playerTwoRoundScore += 1; break;
                    case "J": playerTwoRoundScore += 11; break;
                    case "Q": playerTwoRoundScore += 12; break;
                    case "K": playerTwoRoundScore += 13; break;
                    case "X": hasTwoX = true; break;
                    case "Y": playerTwoScore -= 200; break;
                    case "Z": playerTwoScore *= 2; break;
                    default: playerTwoRoundScore += 12 - int.Parse(card); break;
                }
            }

            if (hasOneX && hasTwoX)
            {
                playerOneScore += 50;
                playerTwoScore += 50;
            }
            else if (hasOneX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (hasTwoX)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            if (playerOneRoundScore > playerTwoRoundScore)
            {
                playerOneScore += playerOneRoundScore;
                playerOneGames++;
            }
            else if (playerOneRoundScore < playerTwoRoundScore)
            {
                playerTwoScore += playerTwoRoundScore;
                playerTwoGames++;
            }
        }

        if (playerOneScore == playerTwoScore)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", playerOneScore);
        }
        else
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", playerOneScore);
                Console.WriteLine("Games won: {0}", playerOneGames);
            }
            else
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", playerTwoScore);
                Console.WriteLine("Games won: {0}", playerTwoGames);
            }
        }

    }
}

