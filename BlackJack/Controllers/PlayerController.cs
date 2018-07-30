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
        public ActionResult Shuffe()
        {
            return View(repository.GetPlayers());
        }
        
        

        [HttpPost]
        public ActionResult Shuffle(List<Player> players)
        {
            var newPlayers = GenerateCardsAllUsers(players);
            return RedirectToAction("Shuffle",newPlayers);
        }

        private List<Player> GenerateCardsAllUsers(List<Player> playersList)
        {
            foreach (var p in playersList)
            {
                p.Count += GenerateCard();
            }
            return playersList;
        }

        private int GenerateCard()
        {
            return random.Next(1, 11);
        }
    }
}