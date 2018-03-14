using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame{
    class Program{
        static void Main(string[] args){

            string playerName;
            Dealer dealer = new Dealer();
            Console.Write("Please enter your name: ");
            playerName = Console.ReadLine();
            Player player = new Player(playerName,5000);
            Console.Clear();
            bool notQuit = true;
            int option;
            while (notQuit) {
                option = Menu.PrintMenu();
                Console.Clear();
                switch (option) {
                    case 1:
                        int cardsToDeal = Menu.HowManyCardsToDeal(player, dealer);
                        player.Hand.AddRange(dealer.Deal(cardsToDeal));
                        break;
                    case 2:
                        player.PrintHand();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        dealer.PrintHand();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Blackjack blackjack = new Blackjack(player,dealer);
                        blackjack.Play();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }

            Console.ReadKey();

        }
    }
}
