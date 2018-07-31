using System;
using System.Threading;

namespace BlckJack.GameLogic
{
    public static class HelpMethods
    {
        public static void GenerateRandomCard(this Player player)
        {
            Random random = new Random();
            Thread.Sleep(100);
            player.Count += random.Next(2, 11);
        }


        public static void GiveCardToPlayer(Player player)
        {
            if (player.Count <= 21)
            {
                player.GenerateRandomCard();
            }
        }

        public static void GiveCardsBots(Game game)
        {
            Random random = new Random();
            foreach (var b in game.Bots)
            {
                if (b.Count < 21)
                {
                    if (random.Next(100) < 50)
                    {
                        b.Count += random.Next(1, 11);
                    }
                }
            }
        }

        public static void GiveCardsOnStartup(Game game)
        {
            foreach (var b in game.Bots)
            {
                b.GenerateRandomCard();
                b.GenerateRandomCard();
            }

            game.Player.GenerateRandomCard();
            game.Player.GenerateRandomCard();

        }

        public static void DisplayCount(Game game)
        {
            Console.WriteLine("Dealer: " + game.Dealer.Count);
            Console.WriteLine("You: " + game.Player.Count);
            foreach (var b in game.Bots)
            {
                Console.WriteLine("{0}: {1}", b.Name, b.Count);
            }
        }

        public static Player DetectWinner(Game game)
        {
            Player winner = new Player();

            //Find winner among bots
            foreach (var b in game.Bots)
            {
                if (b.Count <= 21 &&
                    winner.Count < b.Count)
                {
                    winner = b;
                }
            }

            if (game.Player.Count <= 21 && game.Player.Count > winner.Count)
            {
                winner = game.Player;

            }
            else if (game.Dealer.Count >= winner.Count)
            {
                winner = game.Dealer;
            }

            return winner;
        }

        public static void GiveDealerCards(Player dealer)
        {
            Random random = new Random();
            bool isNotEnough = true;

            while (isNotEnough)
            {
                int randomCount = random.Next(1, 11);

                if (dealer.Count + randomCount > 21)
                {
                    isNotEnough = false;
                }
                else
                {
                    dealer.Count += randomCount;
                    isNotEnough = true;
                }
            }

            Console.WriteLine("{0}: {1}", dealer.Name, dealer.Count);
        }
    }
}
    

