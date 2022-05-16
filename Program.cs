using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Card gameCard = new Card();
            bool quit = false;

            do
            {
                int currentCard = gameCard.previousCard();
                Console.WriteLine($"Current card: {currentCard}");
                int nextCard = gameCard.newCard();

                Console.Write("Will the next card be higher or lower (H/L): ");
                string guess = Console.ReadLine();
                if (guess.ToUpper() == "H" && nextCard >= currentCard)
                {
                    player1.correctGuess();
                }
                else if (guess.ToUpper() == "L" && nextCard <= currentCard)
                {
                    player1.correctGuess();
                }
                else
                {
                    player1.incorrectGuess();
                }

                Console.WriteLine($"The card was: {nextCard}");
                Console.WriteLine($"Points: {player1.points}");

                
                if (player1.points > 0)
                {
                    Console.Write("Continue? (y/n): ");
                    string response = Console.ReadLine();
                    if (response.ToUpper() == "N")
                    {
                        quit = true;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry you lost");
                    quit = true;
                }
                Console.WriteLine();

            }while (quit == false);
        }
    }
}