using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    class Game
    {
        public List<Player> Players { get; set; }

        public List<Card> CommunityCardsList { get; set; }
        
        public Deck deck { get; set; }

        string Player_1 = "Player 1";
        string Player_2 = "Player 2";

        public Game()
        {
            Players = new List<Player>();

            CommunityCardsList = new List<Card>();

            Players.Add(new Player(Player_1));
            Players.Add(new Player(Player_2));

            Deck deck = new Deck();
        }

        public void DealCards()
        {
            foreach (Player player in Players)
            {
                player.Hand.Add(deck.DrawCardFromDeck());
                player.Hand.Add(deck.DrawCardFromDeck());
            }
        }

        public void CommunityCards()
        {
            CommunityCardsList.Add(deck.DrawCardFromDeck());
            CommunityCardsList.Add(deck.DrawCardFromDeck());
            CommunityCardsList.Add(deck.DrawCardFromDeck());
        }

        public void ShareLists()
        {
            foreach (Player player in Players)
            {
                player.Hand.AddRange(CommunityCardsList);
            }
        }
    }
}   

