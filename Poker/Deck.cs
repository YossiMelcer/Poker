using System;
using System.Collections.Generic;
using System.Text;


namespace Poker
{
    public class Deck
    {
        public List<Card> listOfCards { get; }

        public Deck()
        {
            listOfCards = new List<Card>();
            CreateDeck();
            Shuffle(listOfCards);
        }


        private void CreateDeck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    Card card = new Card(suit, rank);
                    listOfCards.Add(card);
                }
            }
        }
        

        private void Shuffle(List<Card> listOfCards)
        {
            Random rnd = new Random();
            int n = listOfCards.Count;
            for (int i = 0; i < n; i++)
            {
                int j = i + rnd.Next(n - i);
                Card tmp = listOfCards[j];
                listOfCards[j] = listOfCards[i];
                listOfCards[i] = tmp;
            }

            foreach(Card item in listOfCards)
            {
                Console.WriteLine("{0} of {1}", item.Rank, item.Suit);
            }

            Console.ReadKey();

        }
    }
}
