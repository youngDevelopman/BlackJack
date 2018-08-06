using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJackGame.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Count
        {
            get
            {
                int totalValue = 0;
                foreach(var card in CardInHand)
                {
                    totalValue += card.Value;
                }

                return totalValue;
            }
        }

        public List<Card> CardInHand { get; set; }

        public Player()
        {
            CardInHand = new List<Card>();
        }
    }
}