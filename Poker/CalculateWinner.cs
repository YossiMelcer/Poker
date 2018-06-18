using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    class CalculateWinner
    {
        Deck deck1 = new Deck();

        Card card1 = deck1.DrawCardFromDeck();

        private List<Card> PlayerHand = new List<Card>();
        PlayerHand.Add(card1); 
        
        public static bool RoyalFlushCheck(List<Card> PlayerHand)
        {
            PlayerHand = PlayerHand.OrderBy(x => x.Suit).ThenBy(x => x.Rank).ToList();

            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }
            
            return true;
        }
    }
}
