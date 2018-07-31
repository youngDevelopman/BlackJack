using System.Data.Entity;

namespace BlckJack.Models
{
    public class GameHistoryContext : DbContext
    {
        public GameHistoryContext() : 
            base("GameHistoryContext")
        {
            Database.SetInitializer<DbContext>(null);
        }


        public DbSet<GameHistoryModel> GameHistory { get; set; }

       
    }
}
