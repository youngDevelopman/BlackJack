using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackJackGame.Game
{
    public class UserGameOptions
    {
        [Display(Name = "Number of bots")]
        public int NumberOfPlayers { get; set; }

        [Display(Name = "Your name")]
        public string PlayerName { get; set; }       

    }
}