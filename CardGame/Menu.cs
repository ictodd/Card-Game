using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {
    public static class Menu {

        public static int PrintMenu() {
            int tempOption;
            bool valid = false;

            while (!valid) {
                Console.WriteLine("Please choose one of the following:");
                Console.WriteLine();
                Console.WriteLine("\t1. Deal");
                Console.WriteLine("\t2. Show Player Hand");
                Console.WriteLine("\t3. Show Dealer Deck");
                Console.WriteLine("\t4. Player Blackjack");
                Console.WriteLine("\t5. Quit");
                Console.WriteLine();
                Console.Write("Please select an option: ");

                if (int.TryParse(Console.ReadLine(), out tempOption)) {
                    valid = true;
                    return tempOption;
                }
            }

            return -1;
        }

        public static int HowManyCardsToDeal(Player player, Dealer dealer) {
            int tempOption;
            bool valid = false;

            while (!valid) {
                Console.Write("How many cards would you like: ");

                if (int.TryParse(Console.ReadLine(), out tempOption)) {

                    if(tempOption > dealer.Deck.Cards.Count) {
                        Console.WriteLine("That is more than the dealer has in his deck! (which is " + dealer.Deck.Cards.Count + ")");
                        return -1;
                    }
                    valid = true;
                    return tempOption;
                }
            }

            return -1;
        }

        public static void Clear() {
            for(int i = 0; i< 100; i++) {
                Console.WriteLine();
            }
        }

    }
}
