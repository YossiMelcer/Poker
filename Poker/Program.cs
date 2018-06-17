using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            List<Card> PlayerHand = new List<Card>();

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    Card card = new Card(suit, rank);
                    PlayerHand.Add(card);
                }
            }

            PlayerHand = PlayerHand.OrderBy(x => x.Suit).ThenBy(x => x.Rank).ToList();

            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Console.ReadKey();
            
        }

    }
}
 