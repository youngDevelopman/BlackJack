using BlackJack.Models;
using System;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace BlackJack.Controllers
{
    public class PlayerController : Controller
    {
        PlayerContext playerDb = new PlayerContext();

        // GET: Player
        public ActionResult Game()
        {
            return View(playerDb.Players);
        }

        [HttpPost]
        public ViewResult Shuffle()
        {
            for(int i = 0; i < playerDb.Players.Count(); i++)
            {
                
            }
            return View("Game",playerDb.Players);
        }

        private static Cards GetRandomCards()
        {
            var v = Enum.GetValues(typeof(Cards));
            return (Cards)v.GetValue(new Random().Next(0,v.Length));
        }
    }
}