using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    class CalculateWinner
    {

        //will make dummy "PlayerHand" to use here. PlayerHand means hand + community cards, just had nothing better to call it
        
        public static int RoyalFlushCheck(List<Card> PlayerHand)
        {
            PlayerHand = PlayerHand.OrderBy(x => x.Suit).ThenBy(x => x.Rank).ToList();

            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }



            Console.ReadKey();
            
            return 1;
        }
    }
}
