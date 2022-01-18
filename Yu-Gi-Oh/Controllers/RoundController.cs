﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;

namespace Yu_Gi_Oh.Controllers
{
    public class RoundController : Controller
    {
        // GET: Round
        public ActionResult Index()
        {

            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();

            return View(PlayerController._db.Rounds);
        }
    }
}