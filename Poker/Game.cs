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
        
        public Game()
        {
            Players = new List<Player>();

            CommunityCardsList = new List<Card>();
            
            deck = new Deck();
        }

        public void DealCards()
        {
            foreach (Player player in Players)
            {
                player.Hand.Add(deck.DrawCardFromDeck());
                player.Hand.Add(deck.DrawCardFromDeck());
            }
        }

        public void DealCommunityCards()
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

