using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public enum CardRank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };

    public enum CardSuit { Diamonds = 1, Hearts, Clubs, Spades };

    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardRank Rank { get; set; }

        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public string CardToString()
        {
            string s = Suit.ToString();
            string t = Rank.ToString();
            return String.Join(s, t);
        }
    }
}



    