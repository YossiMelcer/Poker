using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of players");
            int PlayerNumber = Convert.ToInt32(Console.ReadLine());
            
            Game game = new Game();
            
            for (int i = 1; i <= PlayerNumber; i++)
            {
                game.Players.Add(new Player("Player " + i));
            }
            
            game.DealCards();

            foreach (Player player in game.Players)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine(player.Chips);
                
                foreach (Card card in player.Hand)
                {
                    Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
                }
            }
            
            foreach (Card item in game.deck.ListOfCards)
            {
                Console.WriteLine("{0} of {1}", item.Rank, item.Suit);
            }

            Console.WriteLine(game.deck.ListOfCards.Count);

            //CalculateWinner calc = new CalculateWinner();

            Console.ReadKey();
        }

    } 
}
 