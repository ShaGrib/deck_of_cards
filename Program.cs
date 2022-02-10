using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player bob  = new Player("Bob");
            deck.shuffle();
            bob.draw(deck);
            bob.draw(deck);
            bob.discard(0);
        }
    }
}