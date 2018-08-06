using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJackGame.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Suit { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string ImageSource { get; set; }
    }
}