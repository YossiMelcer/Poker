using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    class CalculateWinner
    {
        public CalculateWinner(List<Card> CombinationHand)
        {
            RoyalFlushCheck(CombinationHand);
            StraightFlushCheck(CombinationHand);
            FourOfAKindCheck(CombinationHand);
            FullHouseCheck(CombinationHand);
            FlushCheck(CombinationHand);
            StraightCheck(CombinationHand);
            ThreeOfAKindCheck(CombinationHand);
            TwoPairCheck(CombinationHand);
            PairCheck(CombinationHand);
        }

        private void DummyHand()
        {
            Deck deck1 = new Deck();
            
            List<Card> PlayerHand = new List<Card>();
            PlayerHand.Add(new Card(CardSuit.Clubs, CardRank.Ace));
            PlayerHand.Add(new Card(CardSuit.Hearts, CardRank.Three));
            PlayerHand.Add(new Card(CardSuit.Clubs, CardRank.Three));
            PlayerHand.Add(new Card(CardSuit.Diamonds, CardRank.Five));
            PlayerHand.Add(new Card(CardSuit.Diamonds, CardRank.Five));
            PlayerHand.Add(new Card(CardSuit.Spades, CardRank.Ten));
            PlayerHand.Add(new Card(CardSuit.Spades, CardRank.Jack));
            
            PairCheck(PlayerHand);
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
            if (FlushCheck(PlayerHand) && StraightCheck(PlayerHand))
                return true;

            return false;
        }

        public static bool FourOfAKindCheck(List<Card> PlayerHand)
        {
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Dictionary<CardRank, List<Card>> groupedCards = PlayerHand.GroupBy(card => card.Rank).ToDictionary(group => group.Key, group => group.ToList());

            groupedCards.ToList().ForEach(x => Console.WriteLine(x.Key));

            var containsFourOfAKind = groupedCards.Any(a => a.Value.Count == 4);

            if (containsFourOfAKind)
                return true;

            return false;

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
            List<CardRank> groupedCards = PlayerHand
                .Select(card => card.Rank)
                .OrderBy(rank => rank)
                .ToList();

            foreach (CardRank rank in groupedCards)
            {
                Console.WriteLine("{0}", rank);
            }

           
            int straightCount = 1;

            for (int i = 0; i <= groupedCards.Count - 2; i++)
            {
                if (straightCount == 5)
                    break;

                Console.WriteLine(straightCount);

                int currentRankValue = (int)groupedCards[i];
                
                if ((int)groupedCards[i + 1] - currentRankValue == 1)
                    straightCount++;
                
                else if (currentRankValue == 2 && (int)groupedCards[i + 1] == 14)
                    straightCount++;

                else if (currentRankValue - (int)groupedCards[i + 1] > 1)
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

        public static bool ThreeOfAKindCheck(List<Card> PlayerHand)
        {
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Dictionary<CardRank, List<Card>> groupedCards = PlayerHand.GroupBy(card => card.Rank).ToDictionary(group => group.Key, group => group.ToList());

            groupedCards.ToList().ForEach(x => Console.WriteLine(x.Key));

            var containsTriple = groupedCards.Any(a => a.Value.Count == 3);

            if (containsTriple)
                return true;

            return false;
        }

        public static bool TwoPairCheck(List<Card> PlayerHand)
        {
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            List<CardRank> groupedCards = PlayerHand
                .Select(card => card.Rank)
                .OrderBy(rank => rank)
                .ToList();

            bool firstPair = false;

            CardRank foundPairRank = CardRank.Ace;

            for(int i = 0; i <= groupedCards.Count() - 1; i++)
            {
                for(int j = 0; j <= groupedCards.Count() - 1; j++)
                {
                    if (j == i)
                        continue;
                    if (groupedCards[i] == groupedCards[j])
                    {
                        firstPair = true;
                        foundPairRank = groupedCards[i];
                        break;
                    }
                }
            }

            Console.WriteLine(firstPair);

            Console.WriteLine(foundPairRank);

            groupedCards.RemoveAll(a => a == foundPairRank);

            foreach (CardRank rank in groupedCards)
            {
                Console.WriteLine(rank);
            }

            bool secondPair = false;

            for (int i = 0; i <= groupedCards.Count() - 1; i++)
            {
                for (int j = 0; j <= groupedCards.Count() - 1; j++)
                {
                    if (j == i)
                        continue;
                    if (groupedCards[i] == groupedCards[j])
                    {
                        secondPair = true;
                        
                        break;
                    }
                }
            }
            
            if (firstPair && secondPair)
            {
                Console.WriteLine("Two Pair");
                return true;
            }

            return false;
        }

        public static bool PairCheck(List<Card> PlayerHand)
        {
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }

            Dictionary<CardRank, List<Card>> groupedCards = PlayerHand.GroupBy(card => card.Rank).ToDictionary(group => group.Key, group => group.ToList());

            groupedCards.ToList().ForEach(x => Console.WriteLine(x.Key));

            var containsPair = groupedCards.Any(a => a.Value.Count == 2);

            if (containsPair)
                return true;

            return false;
        }
    }
}