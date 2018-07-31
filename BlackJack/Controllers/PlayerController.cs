using BlackJack.Interfaces;
using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BlackJack.Controllers
{
    public class PlayerController : Controller
    {
        IRepository repository;
        static Random random = new Random();

        public PlayerController(IRepository r)
        {
            repository = r;
        }

        // GET: Player
        [HttpGet]
        public ActionResult Shuffle()
        {
            return View(repository.GetPlayers());
        }

        [HttpPost]
        public ActionResult Shuffle(List<Player> players)
        {
            foreach(var p in players)
            {
                p.Count += random.Next(2, 11);
            }
            return View(players);
        }
    }
}