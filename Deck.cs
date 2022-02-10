using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Deck
    {

        private int deckSize;
        // public Card currentCard;

        // public enum Suit
        // {
        //     Diamonds = 1, Hearts = 2, Clubs = 3, Spades = 4
        // }

        // public enum Rank
        // {
        //     Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13
        // }
        List<Card> cards = new List<Card>();

        List<string> cardSuits = new List<string>
        {
            "Diamonds", "Hearts", "Clubs", "Spades"
        };

        List<string> cardRanks = new List<string>
        {
            "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"
        };

        public Deck()
        {
            deckSize = 52;
            reset();
        }
        public List<Card> reset()
        {
            for (int i = 0; i < cardRanks.Count; i++)
            {
                foreach (string su in cardSuits)
                {
                    Card card = new Card(cardRanks[i], su, i + 1);
                    cards.Add(card);
                }
            }
            return cards;
        }

        public Card Deal()
        {
            Card theCard = cards[0];
            cards.RemoveAt(0);
            deckSize = cards.Count;
            Console.WriteLine(theCard);
            return theCard;
        }

        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                Card temp = cards[i];
                int index = rand.Next(0, cards.Count);
                cards[i] = cards[index];
                cards[index] = temp;
            }
        }
    }
}