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
            PlayerHand.Add(new Card(CardSuit.Clubs, CardRank.Ace));
            PlayerHand.Add(new Card(CardSuit.Hearts, CardRank.Two));
            PlayerHand.Add(new Card(CardSuit.Clubs, CardRank.Three));
            PlayerHand.Add(new Card(CardSuit.Diamonds, CardRank.Four));
            PlayerHand.Add(new Card(CardSuit.Diamonds, CardRank.Five));
            PlayerHand.Add(new Card(CardSuit.Spades, CardRank.Ten));
            PlayerHand.Add(new Card(CardSuit.Spades, CardRank.Jack));
            //PlayerHand.Add(card1);
            //PlayerHand.Add(card2);
            //PlayerHand.Add(card3);
            //PlayerHand.Add(card4);
            //PlayerHand.Add(card5);
            //PlayerHand.Add(card6);
            //PlayerHand.Add(card7);

            StraightCheck(PlayerHand);
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

                if (RoyalFlushTest.Count() == 5)
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
            return false;
        }

        public static bool FourOfAKindCheck(List<Card> PlayerHand)
        {
            var AceList = PlayerHand.Where(card => card.Rank == CardRank.Ace).ToList();
            var TwoList = PlayerHand.Where(card => card.Rank == CardRank.Two).ToList();
            var ThreeList = PlayerHand.Where(card => card.Rank == CardRank.Three).ToList();
            var FourList = PlayerHand.Where(card => card.Rank == CardRank.Four).ToList();
            var FiveList = PlayerHand.Where(card => card.Rank == CardRank.Five).ToList();
            var SixList = PlayerHand.Where(card => card.Rank == CardRank.Six).ToList();
            var SevenList = PlayerHand.Where(card => card.Rank == CardRank.Seven).ToList();
            var EightList = PlayerHand.Where(card => card.Rank == CardRank.Eight).ToList();
            var NineList = PlayerHand.Where(card => card.Rank == CardRank.Nine).ToList();
            var TenList = PlayerHand.Where(card => card.Rank == CardRank.Ten).ToList();
            var JackList = PlayerHand.Where(card => card.Rank == CardRank.Jack).ToList();
            var QueenList = PlayerHand.Where(card => card.Rank == CardRank.Queen).ToList();
            var KingList = PlayerHand.Where(card => card.Rank == CardRank.King).ToList();

            if (AceList.Count() == 4 ||
                TwoList.Count() == 4 ||
                ThreeList.Count() == 4 ||
                FourList.Count() == 4 ||
                FiveList.Count() == 4 ||
                SixList.Count() == 4 ||
                SevenList.Count() == 4 ||
                EightList.Count() == 4 ||
                NineList.Count() == 4 ||
                TenList.Count() == 4 ||
                JackList.Count() == 4 ||
                QueenList.Count() == 4 ||
                KingList.Count() == 4)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public static bool FullHouseCheck(List<Card> PlayerHand)
        {
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Dictionary<CardRank, List<Card>> groupedCards = PlayerHand.GroupBy(card => card.Rank).ToDictionary(group => group.Key, group => group.ToList());

            groupedCards.ToList().ForEach(x => Console.WriteLine(x.Key));

            var containsTriple = groupedCards.Any(a => a.Value.Count == 3);
            var containsPair = groupedCards.Any(a => a.Value.Count == 2);

            if (containsTriple && containsPair)
            {
                Console.WriteLine("Full House");
                return true;
            }

            return false;

        }

        public static bool FlushCheck(List<Card> PlayerHand)
        {
            var DiamondsList = PlayerHand.Where(s => s.Suit == CardSuit.Diamonds).ToList();
            var HeartsList = PlayerHand.Where(s => s.Suit == CardSuit.Hearts).ToList();
            var ClubsList = PlayerHand.Where(s => s.Suit == CardSuit.Clubs).ToList();
            var SpadesList = PlayerHand.Where(s => s.Suit == CardSuit.Spades).ToList();

            if (DiamondsList.Count() >= 5 ||
               HeartsList.Count() >= 5 ||
               ClubsList.Count() >= 5 ||
               SpadesList.Count() >= 5)
            {
                return true;
            }

            return false;
        }

        public static bool StraightCheck(List<Card> PlayerHand)
        {
            List<CardRank> uniqueRanks = PlayerHand
                .Select(card => card.Rank)
                .OrderBy(rank => rank)
                .ToList();

            foreach (CardRank rank in uniqueRanks)
            {
                Console.WriteLine("{0}", rank);
            }

           
            int straightCount = 1;

            for (int i = 0; i <= uniqueRanks.Count - 2; i++)
            {
                if (straightCount == 5)
                    break;

                Console.WriteLine(straightCount);

                int currentRankValue = (int)uniqueRanks[i];
                
                if ((int)uniqueRanks[i + 1] - currentRankValue == 1)
                    straightCount++;
                
                else if (currentRankValue == 2 && (int)uniqueRanks[i + 1] == 14)
                    straightCount++;

                else if (currentRankValue - (int)uniqueRanks[i + 1] > 1)
                    straightCount = 1;
            }

            Console.WriteLine();
            Console.WriteLine(straightCount);

            if (straightCount == 5)
            {
                Console.WriteLine("straight");
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}