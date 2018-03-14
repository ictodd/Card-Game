using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {
    public class Blackjack {
        Player player;
        Player dealerAsPlayer;
        Dealer dealer;
        int currentPlayerScore;
        int currentDealerScore;
        int playerBet;

        bool Gameover = false;

        public Blackjack(Player p, Dealer d) {
            this.player = p;
            this.dealer = d;
            dealerAsPlayer = new Player("Dealer");
        }

        public void Play() {

            player.GiveHandBack(dealer);
            player.Hand.AddRange(dealer.Deal(2));
            player.PrintHand();

            dealerAsPlayer.GiveHandBack(dealer);
            dealerAsPlayer.Hand.AddRange(dealer.Deal(2));
            PrintDealerHand();

            PrintHandValue(player);

            playerBet = GetBet();

            // player has made bet, so show the hand
            dealerAsPlayer.PrintHand();
            string choice;
            bool validOption = false;
            while (!validOption) {
                Console.Write("Would you like to hit, or stay (h/s)?:");
                choice = Console.ReadLine();
                if(choice.ToLower() == "h" || choice.ToLower() == "s") {
                    validOption = true;
                } else {
                    Console.WriteLine("Invalid choice. Try again...");
                    Console.Clear();
                }
            }

        }

        private int GetBet() {
            int tempBet = -1;
            bool validBet = false;

            while (!validBet) {
                Console.Write("How much would you like to bet?:");
                if (int.TryParse(Console.ReadLine(), out tempBet)){
                    if(tempBet < 0) {
                        Console.WriteLine("Please enter a positive bet.");
                        continue;
                    } else if(tempBet > player.BankBalance) {
                        Console.WriteLine("You cannot bet a greater amount than your current bank balance.");
                        Console.WriteLine("Your current bank balance is " + player.BankBalance.ToString("n"));
                        continue;
                    }
                    validBet = true;
                } else {
                    Console.WriteLine("Please enter a valid bet.");
                }
            }
            return tempBet;

        }

        private void PrintHandValue(Player p) {
            string handScoreMsg = "";

            if (ContainsAce(p.Hand)) {
                handScoreMsg = GetHandValue(p.Hand, 1) + " (" + GetHandValue(p.Hand,11) + ")";
            } else {
                handScoreMsg = GetHandValue(p.Hand, 1).ToString();
            }

            Console.WriteLine(p.Name + "'s Hand score is: " + handScoreMsg);
        }

        private void PrintDealerHand() {
            Console.WriteLine("\n" + "Dealer" + "'s Hand:\n");
            Console.WriteLine(dealerAsPlayer.Hand[0].Value + " of " + dealerAsPlayer.Hand[0].Suit + "s");
            Console.WriteLine("**Hidden**");
            Console.WriteLine();
        }

        private bool ContainsAce(List<Card> hand) {
            foreach(Card card in hand) {
                if (card.Value == Value.Ace) return true;
            }
            return false;
        }

        private int GetHandValue(List<Card> hand, int aceValue) {
            int result = 0;
            foreach(Card card in hand) {
                if(card.Value != Value.Ace) {
                    result += (int)card.Value;
                }else if(card.Value == Value.Ace) {
                    result += aceValue;
                }
            }
            return result;
        }
    }
}
