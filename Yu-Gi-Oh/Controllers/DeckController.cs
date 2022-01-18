using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;

namespace Yu_Gi_Oh.Controllers
{
    public class DeckController : Controller
    {
        // GET: Deck
        public ActionResult Index()
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();

            return View(PlayerController._db.Decks);
        }

        public ActionResult AnotherIndex()
        {
            return View();
        }
    }
}