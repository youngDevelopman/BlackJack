using BlackJackGame.Game;
using System.Web.Mvc;

namespace BlackJackGame.Controllers
{
    public class HomeController : Controller
    {
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
            return View();
        }


    }
}