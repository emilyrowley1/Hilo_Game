using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Card newCard = new Card();
            Console.WriteLine(newCard.drawCard());
        }
    }
}