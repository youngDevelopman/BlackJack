using BlckJack.GameLogic;
using BlckJack.Models;
using System;
using System.Data.Entity;

namespace BlckJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<GameHistoryContext>(null);
           
            Game currentGame;
            GameHistoryContext gameHistoryContext = new GameHistoryContext();
            Console.WriteLine("Do you want to start a new game?");
            Console.WriteLine("Y/N");
            string input = Console.ReadLine();
            ConsoleKey continueConfirm;

            if (input == "Y" || input == "y")
            {
                // New game registration
                currentGame = new Game();
                HelpMethods.GiveCardsOnStartup(currentGame);
                bool isContinue = true;
                Player winner = null;

                while (isContinue)
                {
                    HelpMethods.DisplayCount(currentGame);
                    if (currentGame.Player.Count <= 21)
                    {

                        Console.WriteLine("Do you want to continue this round?");

                        continueConfirm = Console.ReadKey(true).Key;
                        Console.WriteLine();

                        if (continueConfirm == ConsoleKey.Y)
                        {
                            isContinue = true;
                            HelpMethods.GiveCardToPlayer(currentGame.Player);
                        }
                        else
                        {
                            isContinue = false;
                        }
                    }
                    else
                    {
                        HelpMethods.GiveDealerCards(currentGame.Dealer);
                        winner = HelpMethods.DetectWinner(currentGame);
                        isContinue = false;
                    }
                }

                if (winner == null)
                {
                    HelpMethods.GiveDealerCards(currentGame.Dealer);
                    winner = HelpMethods.DetectWinner(currentGame);
                }

                Console.WriteLine("{0} have won ", winner.Name);

                GameHistoryModel gameHistoryModel = new GameHistoryModel()
                {
                    WinnerCount = winner.Count,
                    WinnerId = winner.Id,
                    WinnerName = winner.Name,
                };

                gameHistoryContext.GameHistory.Add(gameHistoryModel);
                gameHistoryContext.SaveChanges();

            }
            else
            {
                Console.WriteLine("Game has ended.");
            }

            Console.ReadKey();

        }

    }
}
