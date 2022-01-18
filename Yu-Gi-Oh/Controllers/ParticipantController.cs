using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;
using Yu_Gi_Oh.Models;

namespace Yu_Gi_Oh.Controllers
{
    public class ParticipantController : Controller
    {
        // GET: Participant
        public ActionResult Index(ContestPlay contest)
        {

            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            
            return View(PlayerController._db.Participants);
        }
    }
}