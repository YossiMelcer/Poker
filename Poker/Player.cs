using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public int Chips { get; set; }
        public bool IsInRound { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            Chips = 250;
            IsInRound = true;
            PrintCards();
        }

        public void PrintCards()
        {
            foreach(Card item in Hand)
            {
                Console.WriteLine(item.CardToString());
            }
        }
        
    }
}
