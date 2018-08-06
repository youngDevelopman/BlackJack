using BlackJackGame.Models;
using System.Collections.Generic;

namespace BlackJackGame.Game
{
    public class GameModel
    {
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        public List<Bot> Bots { get; set; }
        public static List<Card> Cards { get; set; }

        static GameModel()
        {
            Cards = new List<Card>();

            // Add all clubs
            Cards.Add(new Card() { Id = 0, Name = "Two", Suit = "Clubs", Value = 2 });
            Cards.Add(new Card() { Id = 1, Name = "Three", Suit = "Clubs", Value = 3 });
            Cards.Add(new Card() { Id = 2, Name = "Four", Suit = "Clubs", Value = 4 });
            Cards.Add(new Card() { Id = 3, Name = "Five", Suit = "Clubs", Value = 5 });
            Cards.Add(new Card() { Id = 4, Name = "Six", Suit = "Clubs", Value = 6 });
            Cards.Add(new Card() { Id = 5, Name = "Seven", Suit = "Clubs", Value = 7 });
            Cards.Add(new Card() { Id = 6, Name = "Eight", Suit = "Clubs", Value = 8 });
            Cards.Add(new Card() { Id = 7, Name = "Nine", Suit = "Clubs", Value = 9 });
            Cards.Add(new Card() { Id = 8, Name = "Ten", Suit = "Clubs", Value = 10 });
            Cards.Add(new Card() { Id = 9, Name = "Jack", Suit = "Clubs", Value = 10 });
            Cards.Add(new Card() { Id = 10, Name = "Queen", Suit = "Clubs", Value = 10 });
            Cards.Add(new Card() { Id = 11, Name = "King", Suit = "Clubs", Value = 10 });
            Cards.Add(new Card() { Id = 12, Name = "Ace", Suit = "Clubs", Value = 11 });


            // Add all Diamonds
            Cards.Add(new Card() { Id = 13, Name = "Two", Suit = "Diamonds", Value = 2 });
            Cards.Add(new Card() { Id = 14, Name = "Three", Suit = "Diamonds", Value = 3 });
            Cards.Add(new Card() { Id = 15, Name = "Four", Suit = "Diamonds", Value = 4 });
            Cards.Add(new Card() { Id = 16, Name = "Five", Suit = "Diamonds", Value = 5 });
            Cards.Add(new Card() { Id = 17, Name = "Six", Suit = "Diamonds", Value = 6 });
            Cards.Add(new Card() { Id = 18, Name = "Seven", Suit = "Diamonds", Value = 7 });
            Cards.Add(new Card() { Id = 19, Name = "Eight", Suit = "Diamonds", Value = 8 });
            Cards.Add(new Card() { Id = 20, Name = "Nine", Suit = "Diamonds", Value = 9 });
            Cards.Add(new Card() { Id = 21, Name = "Ten", Suit = "Diamonds", Value = 10 });
            Cards.Add(new Card() { Id = 22, Name = "Jack", Suit = "Diamonds", Value = 10 });
            Cards.Add(new Card() { Id = 23, Name = "Queen", Suit = "Diamonds", Value = 10 });
            Cards.Add(new Card() { Id = 24, Name = "King", Suit = "Diamonds", Value = 10 });
            Cards.Add(new Card() { Id = 25, Name = "Ace", Suit = "Diamonds", Value = 11 });

            //Add all hearts
            Cards.Add(new Card() { Id = 26, Name = "Two", Suit = "Hearts", Value = 2 });
            Cards.Add(new Card() { Id = 27, Name = "Three", Suit = "Hearts", Value = 3 });
            Cards.Add(new Card() { Id = 28, Name = "Four", Suit = "Hearts", Value = 4 });
            Cards.Add(new Card() { Id = 29, Name = "Five", Suit = "Hearts", Value = 5 });
            Cards.Add(new Card() { Id = 30, Name = "Six", Suit = "Hearts", Value = 6 });
            Cards.Add(new Card() { Id = 31, Name = "Seven", Suit = "Hearts", Value = 7 });
            Cards.Add(new Card() { Id = 32, Name = "Eight", Suit = "Hearts", Value = 8 });
            Cards.Add(new Card() { Id = 33, Name = "Nine", Suit = "Hearts", Value = 9 });
            Cards.Add(new Card() { Id = 34, Name = "Ten", Suit = "Hearts", Value = 10 });
            Cards.Add(new Card() { Id = 35, Name = "Jack", Suit = "Hearts", Value = 10 });
            Cards.Add(new Card() { Id = 36, Name = "Queen", Suit = "Hearts", Value = 10 });
            Cards.Add(new Card() { Id = 37, Name = "King", Suit = "Hearts", Value = 10 });
            Cards.Add(new Card() { Id = 38, Name = "Ace", Suit = "Hearts", Value = 11 });

            //Add all spades
            Cards.Add(new Card() { Id = 39, Name = "Two", Suit = "Spades", Value = 2 });
            Cards.Add(new Card() { Id = 40, Name = "Three", Suit = "Spades", Value = 3 });
            Cards.Add(new Card() { Id = 41, Name = "Four", Suit = "Spades", Value = 4 });
            Cards.Add(new Card() { Id = 42, Name = "Five", Suit = "Spades", Value = 5 });
            Cards.Add(new Card() { Id = 43, Name = "Six", Suit = "Spades", Value = 6 });
            Cards.Add(new Card() { Id = 44, Name = "Seven", Suit = "Spades", Value = 7 });
            Cards.Add(new Card() { Id = 45, Name = "Eight", Suit = "Spades", Value = 8 });
            Cards.Add(new Card() { Id = 46, Name = "Nine", Suit = "Spades", Value = 9 });
            Cards.Add(new Card() { Id = 47, Name = "Ten", Suit = "Spades", Value = 10 });
            Cards.Add(new Card() { Id = 48, Name = "Jack", Suit = "Spades", Value = 10 });
            Cards.Add(new Card() { Id = 49, Name = "Queen", Suit = "Spades", Value = 10 });
            Cards.Add(new Card() { Id = 50, Name = "King", Suit = "Spades", Value = 10 });
            Cards.Add(new Card() { Id = 51, Name = "Ace", Suit = "Spades", Value = 11 });


        }

        public GameModel()
        {
            Player = new Player() { Id = 0, Name = "Player" };
            Dealer = new Player() { Id = 1, Name = "Dealer" };
            Bots = new List<Bot>();

            Bots.Add(new Bot() { Id = 0, Name = "Bill" });
            Bots.Add(new Bot() { Id = 1, Name = "Tom" });
        }

        public GameModel(UserGameOptions userGameOptions) : this()
        {
            Player = new Player() { Name = userGameOptions.PlayerName };
        }
    }
}