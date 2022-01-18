using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;
using Yu_Gi_Oh.Models;

namespace Yu_Gi_Oh.Controllers
{
    public class ContestController : Controller
    {
        // GET: Contest
        public ActionResult Index()
        {

            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();

            return View(PlayerController._db.Contests);
        }

        public ActionResult AnotherIndex(ContestPlay contest)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            return View(contest);
        }

         public ActionResult PIC(ContestPlay contest)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            return View(PlayerController._db.Participants.FindAll(m => m.ContestName == contest.ContestName));
        }

        public ActionResult RC(ContestPlay contest)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            var index = PlayerController._db.Contests.FindIndex(m => m.ContestName == contest.ContestName);
            var rondas = PlayerController._db.Rounds[index].FindAll(m => m.EliminationRoundNumber == null);
            var rondasc = new List<ClassificationRound>();
            foreach (var item in rondas)
            {
                rondasc.Add(PlayerController._db.ClassificationRound.Find(m => m.ClassificationRoundNumber == item.ClassificationRoundNumber));
            }
            return View(rondasc);
        }

        public ActionResult RE(ContestPlay contest)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            var index = PlayerController._db.Contests.FindIndex(m => m.ContestName == contest.ContestName);
            var rondas = PlayerController._db.Rounds[index].FindAll(m => m.EliminationRoundNumber != null);
            var rondasc = new List<EliminationRound>();
            foreach (var item in rondas)
            {
                rondasc.Add(PlayerController._db.EliminationRound.Find(m => m.EliminationRoundNumber == item.EliminationRoundNumber));
            }
            return View(rondasc);
        }

        public ActionResult RoundC(ClassificationRound ronda)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            var round = PlayerController._db.ClassificationRound.Find(m => m.ClassificationRoundNumber == ronda.ClassificationRoundNumber);
            var match = new List<Game>();
            foreach (var item in round.GamesClassification)
            {
                match.Add(PlayerController._db.Games.Find(m => m.GameNumber == item));
            }
            return View(match);
        }

        public ActionResult LP(ClassificationRound ronda)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            var round = PlayerController._db.ClassificationRound.Find(m => m.ClassificationRoundNumber == ronda.ClassificationRoundNumber);
            return View(round.Participant_Puntuation);
        }

        public ActionResult RoundE(EliminationRound ronda)
        {
            if (PlayerController._db == null)
                PlayerController._db = new ContestContext();
            var round = PlayerController._db.EliminationRound.Find(m => m.EliminationRoundNumber == ronda.EliminationRoundNumber);
            var match = new List<Game>();
            foreach (var item in round.GamesElimination)
            {
                match.Add(PlayerController._db.Games.Find(m => m.GameNumber == item));
            }
            return View(match);
        }
    }
}