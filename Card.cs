using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Card
    {
        // public string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        // public string[] suit = {"Hearts", "Diamonds", "Clubs", "Spades"};
        // public int[] val = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        public string stringVal
        {
            get; set;
        }
        public string suit
        {
            get; set;
        }
        public int val
        {
            get; set;
        }

        // public enum suit
        // {
        //     clubs = 1, spades = 2, hearts = 3, diamonds = 4
        // }

        // List<string> cardSuits = new List<string>
        // {
        //     "Diamonds", "Hearts", "Clubs", "Spades"
        // };

        // List<string> cardRanks = new List<string>
        // {
        //     "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"
        // };

        // public enum cardRank
        // {
        //     Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7,
        //     Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13
        // }

        public Card(string sVal, string su, int v)
        {
            stringVal = sVal;
            suit = su;
            val = v;
        }
    }
}