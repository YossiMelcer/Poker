using System;
using System.Collections.Generic;
using System.Text;


namespace Poker
{
    public class Deck
    {
        public List<Card> ListOfCards { get; set; }

        public int CurrentCard { get; private set; }


        public Deck()
        {
            ListOfCards = new List<Card>();
            CreateDeck();
            Shuffle();
            CurrentCard = 0;
        }

        public Card DrawCardFromDeck()
        {
            Card card = ListOfCards[CurrentCard];
            CurrentCard++;
            return card;
        }


        private void CreateDeck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))             
            {
                foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    Card card = new Card(suit, rank);
                    ListOfCards.Add(card);
                }
            }
        }
        

        private void Shuffle()
        {
            Random rnd = new Random();
            int n = ListOfCards.Count;
            for (int i = 0; i < n; i++)
            {
                int j = i + rnd.Next(n - i);
                Card tmp = ListOfCards[j];
                ListOfCards[j] = ListOfCards[i];
                ListOfCards[i] = tmp;
            }

            foreach(Card item in ListOfCards)
            {
                Console.WriteLine("{0} of {1}", item.Rank, item.Suit);
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
