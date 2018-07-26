using System.Data.Entity;

namespace BlackJack.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext() : base("PlayerContext")
        {

        }
        public DbSet<Player> Players { get; set; }
    }
}