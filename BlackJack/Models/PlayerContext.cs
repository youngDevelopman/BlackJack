using BlackJack.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BlackJack.Models
{
    public class PlayerContext : DbContext
    { 
        public DbSet<Player> Players { get; set; }       
    }

    
    public class PlayerRepository : IRepository
    {
        PlayerContext db = new PlayerContext();
        static Random random = new Random();

        public PlayerRepository()
        {
            //SetDefaultValues();
        }
        
        public List<Player> GetPlayers()
        {
            return db.Players.ToList();
        }

       
    }
}