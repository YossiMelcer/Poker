using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    class CalculateWinner
    {
        public CalculateWinner()
        {
            DummyHand();
        }

        private void DummyHand()
        {
            Deck deck1 = new Deck();

            Card card1 = deck1.DrawCardFromDeck();
            Card card2 = deck1.DrawCardFromDeck();
            Card card3 = deck1.DrawCardFromDeck();
            Card card4 = deck1.DrawCardFromDeck();
            Card card5 = deck1.DrawCardFromDeck();
            Card card6 = deck1.DrawCardFromDeck();
            Card card7 = deck1.DrawCardFromDeck();

            List<Card> PlayerHand = new List<Card>();
            PlayerHand.Add(card1);
            PlayerHand.Add(card2);
            PlayerHand.Add(card3);
            PlayerHand.Add(card4);
            PlayerHand.Add(card5);
            PlayerHand.Add(card6);
            PlayerHand.Add(card7);

            StraightFlushCheck(PlayerHand);
        }


        public static bool RoyalFlushCheck(List<Card> PlayerHand)
        {
            PlayerHand = PlayerHand.OrderBy(x => x.Suit).ThenBy(x => x.Rank).ToList();

            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Console.WriteLine();
            Console.WriteLine();

            var DiamondsList = PlayerHand.Where(s => s.Suit == CardSuit.Diamonds).ToList();
            var HeartsList = PlayerHand.Where(s => s.Suit == CardSuit.Hearts).ToList();
            var ClubsList = PlayerHand.Where(s => s.Suit == CardSuit.Clubs).ToList();
            var SpadesList = PlayerHand.Where(s => s.Suit == CardSuit.Spades).ToList();

            
            if ((DiamondsList.Count()) >= 5)
            {
                var RoyalFlushTest = DiamondsList.Where(card => card.Rank == CardRank.Ace
                || card.Rank == CardRank.King
                || card.Rank == CardRank.Queen
                || card.Rank == CardRank.Jack
                || card.Rank == CardRank.Ten).ToList();

                if(RoyalFlushTest.Count() == 5)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }

            if ((HeartsList.Count()) >= 5)
            {
                var RoyalFlushTest = HeartsList.Where(card => card.Rank == CardRank.Ace
                || card.Rank == CardRank.King
                || card.Rank == CardRank.Queen
                || card.Rank == CardRank.Jack
                || card.Rank == CardRank.Ten).ToList();

                if (RoyalFlushTest.Count() == 5)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }

            if ((ClubsList.Count()) >= 5)
            {
                var RoyalFlushTest = ClubsList.Where(card => card.Rank == CardRank.Ace
                                || card.Rank == CardRank.King
                                || card.Rank == CardRank.Queen
                                || card.Rank == CardRank.Jack
                                || card.Rank == CardRank.Ten).ToList();

                if (RoyalFlushTest.Count() == 5)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            if ((SpadesList.Count()) >= 5)
            {
                var RoyalFlushTest = SpadesList.Where(card => card.Rank == CardRank.Ace
                || card.Rank == CardRank.King
                || card.Rank == CardRank.Queen
                || card.Rank == CardRank.Jack
                || card.Rank == CardRank.Ten).ToList();

                if (RoyalFlushTest.Count() == 5)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public static bool StraightFlushCheck(List<Card> PlayerHand)
        {
            PlayerHand = PlayerHand.OrderBy(x => x.Suit).ThenBy(x => x.Rank).ToList();

            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Console.WriteLine();
            Console.WriteLine();

            var DiamondsList = PlayerHand.Where(s => s.Suit == CardSuit.Diamonds).ToList();
            var HeartsList = PlayerHand.Where(s => s.Suit == CardSuit.Hearts).ToList();
            var ClubsList = PlayerHand.Where(s => s.Suit == CardSuit.Clubs).ToList();
            var SpadesList = PlayerHand.Where(s => s.Suit == CardSuit.Spades).ToList();



            return false;
        }
    }
}
