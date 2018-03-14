using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {
    public class Dealer {

        public Deck Deck;

        public Dealer() {
            this.Deck = new Deck();
        }

        public List<Card> Deal(int cardsToDeal) {

            Random rnd = new Random();
            Card tempCard;
            List<Card> cardsToGive = new List<Card>();

            for(int i = 0; i < cardsToDeal; i++) {
                int randomCardToPull = rnd.Next(0, this.Deck.Cards.Count - 1);

                tempCard = Deck.Cards[randomCardToPull];
                Deck.Cards.Remove(tempCard);
                cardsToGive.Add(tempCard);

            }

            return cardsToGive;

        }

        public void PrintHand() {
            Console.WriteLine("\n" + "Dealer" + "'s Hand:\n");
            foreach (Card card in Deck.Cards) {
                Console.WriteLine(card.Value + " of " + card.Suit + "s");
            }
            Console.WriteLine();
        }

    }
}
