using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            int bigBlind = 25;
            int Pot = 0;

            foreach (Card item in game.deck.ListOfCards)
            {
                Console.WriteLine("{0} of {1}", item.Rank, item.Suit);
            }

            Console.WriteLine();

            Console.WriteLine("Enter no. of players");
            int PlayerNumber = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= PlayerNumber; i++)
            {
                game.Players.Add(new Player("Player " + i));
            }
            
            game.DealCards();
            game.Players.ToList();

            foreach (Player player in game.Players)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine(player.Chips);
                
                foreach (Card card in player.Hand)
                {
                    Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pre flop betting:");
            Console.WriteLine();

            for (int i = 0; i < game.Players.Count; i++)
            {
                Console.WriteLine("Player {0} Choose:", i + 1);
                Console.WriteLine();
                Console.WriteLine("1. Fold");
                Console.WriteLine();
                Console.WriteLine("2. Check");
                Console.WriteLine();
                Console.WriteLine("3. Raise");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        game.Players[i].IsInRound = false;
                        break;

                    case 2:
                        game.Players[i].Chips = game.Players[i].Chips - bigBlind;
                        Pot += bigBlind;
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount that you want to raise");
                        int raiseAmount = Convert.ToInt32(Console.ReadLine());
                        game.Players[i].Chips = game.Players[i].Chips - (raiseAmount + bigBlind);
                        Pot += raiseAmount + bigBlind;
                        bigBlind += raiseAmount;
                        break;

                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }

            Console.WriteLine("First round of betting over");
            Console.WriteLine();
            Console.WriteLine("Current amount in the pot:");
            Console.WriteLine(Pot);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            game.DealCommunityCards();

            Console.WriteLine("Flop:");
            Console.WriteLine();

            foreach (Card card in game.CommunityCardsList)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }
            
            Console.WriteLine();

            for (int i = 0; i < game.Players.Count; i++)
            {
                if (!game.Players[i].IsInRound)
                    continue;

                Console.WriteLine("Player {0} Choose:", i+1);
                Console.WriteLine();
                Console.WriteLine("1. Fold");
                Console.WriteLine();
                Console.WriteLine("2. Check");
                Console.WriteLine();
                Console.WriteLine("3. Raise");
                  
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        game.Players[i].IsInRound = false;
                        break;

                    case 2:
                        game.Players[i].Chips = game.Players[i].Chips - bigBlind;
                        Pot += bigBlind;
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount that you want to raise");
                        int raiseAmount = Convert.ToInt32(Console.ReadLine());
                        game.Players[i].Chips = game.Players[i].Chips - (raiseAmount + bigBlind);
                        Pot += raiseAmount + bigBlind;
                        bigBlind += raiseAmount;
                        break;

                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }

            
            Console.WriteLine("Second round of betting over");
            Console.WriteLine();
            Console.WriteLine("Current amount in the pot:");
            Console.WriteLine(Pot);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            game.CommunityCardsList.Add(game.deck.DrawCardFromDeck());

            Console.WriteLine("Third round of betting. Turn:");
            Console.WriteLine();

            foreach (Card card in game.CommunityCardsList)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Console.WriteLine();

            for (int i = 0; i < game.Players.Count; i++)
            {
                if (!game.Players[i].IsInRound)
                    continue;

                Console.WriteLine("Player {0} Choose:", i + 1);
                Console.WriteLine();
                Console.WriteLine("1. Fold");
                Console.WriteLine();
                Console.WriteLine("2. Check");
                Console.WriteLine();
                Console.WriteLine("3. Raise");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        game.Players[i].IsInRound = false;
                        break;

                    case 2:
                        game.Players[i].Chips = game.Players[i].Chips - bigBlind;
                        Pot += bigBlind;
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount that you want to raise");
                        int raiseAmount = Convert.ToInt32(Console.ReadLine());
                        game.Players[i].Chips = game.Players[i].Chips - (raiseAmount + bigBlind);
                        Pot += raiseAmount + bigBlind;
                        bigBlind += raiseAmount;
                        break;

                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }

            Console.WriteLine("Third round of betting over");
            Console.WriteLine();
            Console.WriteLine("Current amount in the pot:");
            Console.WriteLine(Pot);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            game.CommunityCardsList.Add(game.deck.DrawCardFromDeck());

            Console.WriteLine("Fourth round of betting. River:");
            Console.WriteLine();

            foreach (Card card in game.CommunityCardsList)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Console.WriteLine();

            for (int i = 0; i < game.Players.Count; i++)
            {
                if (!game.Players[i].IsInRound)
                    continue;

                Console.WriteLine("Player {0} Choose:", i + 1);
                Console.WriteLine();
                Console.WriteLine("1. Fold");
                Console.WriteLine();
                Console.WriteLine("2. Check");
                Console.WriteLine();
                Console.WriteLine("3. Raise");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        game.Players[i].IsInRound = false;
                        break;

                    case 2:
                        game.Players[i].Chips = game.Players[i].Chips - bigBlind;
                        Pot += bigBlind;
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount that you want to raise");
                        int raiseAmount = Convert.ToInt32(Console.ReadLine());
                        game.Players[i].Chips = game.Players[i].Chips - (raiseAmount + bigBlind);
                        Pot += raiseAmount + bigBlind;
                        bigBlind += raiseAmount;
                        break;

                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }   
            }
            
            Console.WriteLine("Fourth round of betting over");
            Console.WriteLine();

            //CalculateWinner calc = new CalculateWinner();

            var List1 = game.CommunityCardsList.Concat(game.Players[0].Hand);
            List1.ToList();

            
            Console.ReadKey();
        }
    } 
}
 