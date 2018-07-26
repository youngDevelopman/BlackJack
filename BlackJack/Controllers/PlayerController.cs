using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackJack.Controllers
{
    public class PlayerController : Controller
    {
        PlayerContext playerDb = new PlayerContext();
        // GET: Player
        public ActionResult Game()
        {
            IEnumerable<Player> players = playerDb.Players;

            return View(players);
        }
    }
}