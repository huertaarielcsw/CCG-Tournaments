using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;

namespace Yu_Gi_Oh.Controllers
{
    public class ArchetypeController : Controller
    {
        public static ContestContext _db;

        // GET: Archetype
        public ActionResult Index()
        {
            if (_db == null)
                _db = new ContestContext();

            return View(_db.Archetypes);
        }
    }
}