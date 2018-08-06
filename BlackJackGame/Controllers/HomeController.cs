using BlackJackGame;
using BlackJackGame.Game;
using System;
using System.Linq;
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

        
        public void Shuffle()
        {
            Random random = new Random();
            int randomCardId;
            foreach(var b in game.Bots)
            {
                randomCardId= random.Next(0, 52);
                var card = game.Cards.SingleOrDefault(c => c.Id == randomCardId);
                b.CardInHand.Add(card);
            }
        }
    }
}