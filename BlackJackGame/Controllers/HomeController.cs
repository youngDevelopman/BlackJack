﻿using BlackJackGame;
using BlackJackGame.Game;
using System.Web.Mvc;

namespace BlackJackGame.Controllers
{
    public class HomeController : Controller
    {
        static GameModel game;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GameStartMenu()
        {
            UserGameOptions userGameOptions = new UserGameOptions();
            return View(userGameOptions);
        }

        [HttpPost]
        public ActionResult GameStartMenu(UserGameOptions gameOptions)
        {
            game = new GameModel(gameOptions);
            return RedirectToAction("GameSession");
        }

        public ActionResult GameSession()
        {
            return View(game);
        }

        [HttpPost]
        public void Shuffle()
        {

        }
    }
}