using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {
    public enum Suit {
        None,
        Heart,
        Club,
        Diamond,
        Spade
    }

    public enum Value {
        None,
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card {

        public Suit Suit;
        public Value Value;

        public string Symbol;

        public Card(Suit suit, Value value) {

            this.Suit = suit;
            this.Value = value;

            switch (this.Suit) {
                case Suit.Heart:
                    Symbol = "\u2661";
                    break;
                case Suit.Club:
                    this.Symbol = "\u2667";
                    break;
                case Suit.Diamond:
                    this.Symbol = "\u2662";
                    break;
                case Suit.Spade:
                    this.Symbol = "\u2664";
                    break;
            }
        }

    }
}
