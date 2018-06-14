using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    class Game
    {
        public List<Player> Players { get; set; }

        public Deck deck { get; set; }

        string Player_1 = "Player 1";
        string Player_2 = "Player 2";

        List<Card> Hand_1 = new List<Card>();
        List<Card> Hand_2 = new List<Card>();

        public Game()
        {
            Players = new List<Player>();

            Players.Add(new Player(Player_1));
            Players.Add(new Player(Player_2));
             
            Deck deck = new Deck();
            
        }

        public void DealCards(List<Card> listOfCards, List<Card> hand)
        {
            foreach (Player item in Players)
            {
                hand = listOfCards.Take(2).ToList();
                listOfCards.RemoveRange(0, 2);
            }

            
        }
    }
}

