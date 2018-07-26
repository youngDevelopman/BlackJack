namespace BlackJack.Migrations
{
    using BlackJack.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlackJack.Models.PlayerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BlackJack.Models.PlayerContext";
        }

        protected override void Seed(BlackJack.Models.PlayerContext db)
        {
            db.Players.Add(new Player() { Id = 0, Name = "Bill",Count = 0 });
            db.Players.Add(new Player() { Id = 1, Name = "John", Count = 0});
            db.Players.Add(new Player() { Id = 2, Name = "Steve",Count = 0 });

            base.Seed(db);
        }
    }
}
