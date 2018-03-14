using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {
    public class Deck {
        public List<Card> Cards;

        public Deck() {
            Cards = new List<Card>();
            PopulateDeck();
        }

        private void PopulateDeck() {

            Card tempCard;
            Value tempValue = Value.Ace;
            Suit tempSuit = Suit.None;

            for (int i= 0; i < 52; i ++){
                if(i % 13 == 0) {
                    tempValue = Value.Ace;
                    tempSuit += 1;
                } else {
                    tempValue += 1;
                }
                tempCard = new Card(tempSuit, tempValue);
                this.Cards.Add(tempCard);
            }



        }


    }
}
