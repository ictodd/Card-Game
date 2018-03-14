using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {
    public class Player {

        public List<Card> Hand;
        public string Name;
        public long BankBalance;

        public Player(string name) {
            Name = name;
            Hand = new List<Card>();
        }

        public Player(string name, long bankBalance) {
            Name = name;
            Hand = new List<Card>();
            BankBalance = bankBalance;
        }

        public void PrintHand() {
            Console.WriteLine("\n" + this.Name + "'s Hand:\n");
            foreach(Card card in Hand) {
                Console.WriteLine(card.Value + " of " + card.Suit + "s");
            }
            Console.WriteLine();
        }

        public void GiveHandBack(Dealer dealer) {
            dealer.Deck.Cards.AddRange(Hand);
            this.Hand.Clear();
        }

    }
}
