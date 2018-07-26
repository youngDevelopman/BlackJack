using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlackJack.Models
{
    public class PlayerDbInitializer : DropCreateDatabaseAlways<PlayerContext>
    {
        protected override void Seed(PlayerContext db)
        {
            db.Players.Add(new Player() { Id = 0, Name = "Bill", Count = 0 });
            db.Players.Add(new Player() { Id = 1, Name = "John", Count = 0 });
            db.Players.Add(new Player() { Id = 2, Name = "Steve", Count = 0 });

            base.Seed(db);
        }
    }
}