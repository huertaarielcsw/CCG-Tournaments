using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;
using Yu_Gi_Oh.Models;

namespace Yu_Gi_Oh.Controllers
{
    public class PlayerController : Controller
    {
        public static ContestContext _db;
        
        // GET: Player
        public ActionResult Index()
        {
            if (_db == null)
                _db = new ContestContext();
            
            return View(_db.Players);
        }
    }
}