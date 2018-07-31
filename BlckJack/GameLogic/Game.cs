using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlckJack.GameLogic
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public List<Player> Bots { get; set; }

        [Display(Name = "Dealer")]
        public Player Dealer;
        [Display(Name = "You")]
        public Player Player;

        public Game()
        {
            Bots = new List<Player>();
            Player = new Player();
            Dealer = new Player();

            InitializePlayers();
        }

        private void InitializePlayers()
        {
            Player.Name = "User";
            Dealer.Name = "Dealer";
            Dealer.Id = 5;
            Bots.Add(new Player { Id = 6, Name = "John" });
            Bots.Add(new Player { Id = 1, Name = "Ron" });
            Bots.Add(new Player { Id = 2, Name = "Bill" });
            Bots.Add(new Player { Id = 3, Name = "Seth" });
            Bots.Add(new Player { Id = 4, Name = "Miley" });
        }

    }
}
