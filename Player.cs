using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Player
    {
        private string name;

        private List<Card> hand;

        public Player(string nm)
        {
            this.name = nm;
            hand = new List<Card>();
        } 

        public Card draw(Deck d)
        {
            Card theCard = d.Deal();
            hand.Add(theCard);
            return theCard;
        }

        public Card discard(int index)
        {
            if (hand[index] != null)
            {
                Card temp = hand[index];
                hand.RemoveAt(index);
                return temp;
            }else
            {
                return null;
            }
        }
    }
}