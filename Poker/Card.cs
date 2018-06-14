﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public enum CardRank { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    public enum CardSuit { Diamonds = 1, Hearts, Clubs, Spades };

    public class Card
    {
        public CardSuit Suit { get; }
        public CardRank Rank { get; }

        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}



