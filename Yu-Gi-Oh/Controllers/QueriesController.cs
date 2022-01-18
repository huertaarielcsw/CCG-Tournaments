using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yu_Gi_Oh.Context;
using Yu_Gi_Oh.Models;

namespace Yu_Gi_Oh.Controllers
{
    public class QueriesController : Controller
    {

        private ContestContext db = new ContestContext();

        public IQueryable<Player> GetPlayers()
        {

            return db.Players.AsQueryable();
        }
        // GET: Queries
        public ActionResult Index()
        {
            return View();
        }

        #region Query1

        public JsonResult Query1(int n)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_1 = GetQuery_1(n) } };
            return result;
        }

        private IQueryable<Player> GetQuery_1(int n)
        {

            IQueryable<Player> list = GetPlayers();
            list = list.OrderByDescending(p => p.DecksCount);
            List<Player> aux = new List<Player>();
            foreach (var item in list)
            {
                if (n-- == 0) break;
                aux.Add(item);
            }
            return aux.AsQueryable();
        }

        #endregion

        #region Query2

        public JsonResult Query2(int n)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_2 = GetQuery_2(n) } };
            return result;
        }


        private IQueryable<Tuple<string, int>> GetQuery_2(int n)
        {

            IQueryable<Player> list = GetPlayers();
            var aux = list.Join(db.Decks, x => x.PlayerNumber, d => d.PlayerNumber, F).AsQueryable();
            var temp = new List<Tuple<string, int>>();
            foreach (var item in aux.GroupBy(x => x))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();
            var result = new List<Tuple<string, int>>();
            foreach (var item in temp)
            {
                if (n-- == 0) break;
                result.Add(item);
            }

            return result.AsQueryable();
        }
        private string F(Player x, Deck y)
        {
            return y.ArchetypeName;
        }

        #endregion

        #region Query3

        public JsonResult Query3(string n)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_3 = GetQuery_3(n) } };
            return result;
        }


        private IQueryable<Tuple<string, string>> GetQuery_3(string n)
        {

            IQueryable<Player> list = GetPlayers();
            List<Deck> decks = db.Decks.Where(x => x.ArchetypeName == n).ToList();
            var aux = list.Join(decks, x => x.PlayerNumber, d => d.PlayerNumber, F_3).AsQueryable();
            var temp = new List<Tuple<string, int>>();
            var temp1 = new List<Tuple<string, int>>();
            foreach (var item in aux.GroupBy(x => x.Municipality))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            foreach (var item in aux.GroupBy(x => x.Province))
            {
                temp1.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();
            temp1 = temp1.OrderByDescending(x => x.Item2).ToList();
            var result = new List<Tuple<string, string>>();
            result.Add(new Tuple<string, string>(temp1.First().Item1, temp.First().Item1));

            return result.AsQueryable();
        }
        private Deck FD_3(Deck arg)
        {
            return arg;
        }

        private Player F_3(Player x, object y)
        {
            return x;
        }


        #endregion

        #region Query4

        public JsonResult Query4(string n)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_4 = GetQuery_4(n) } };
            return result;
        }


        private IQueryable<char> GetQuery_4(string n)
        {
            IQueryable<Participant> list = db.Participants.AsQueryable();
            var name = "";
            var contest = db.Contests.Where(x => x.ContestName == n).ToList();
            if (contest != null)
            {
                List<Round> rounds = db.Rounds[contest[0].ContestNumber];
                var round = rounds.Last();
                var game = db.Games[round.GameNumber[0] - 1];
                var idWinner = game.WinnerParticipantNumber;
                list = list.Where(x => x.ParticipantNumber == idWinner);
                name = db.Players[db.Participants[idWinner - 1].PlayerNumber - 1].PlayerName;
            }

            return name.AsQueryable();
        }

        #endregion

        #region Query5

        public JsonResult Query5(int n, DateTime i, DateTime f)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_5 = GetQuery_5(n, i, f) } };
            return result;
        }


        private IQueryable<Tuple<string, int>> GetQuery_5(int n, DateTime i, DateTime f)
        {
            IQueryable<Participant> list = db.Participants.AsQueryable();
            var name = "";
            var contestIn = new List<ContestPlay>();
            foreach (var item in db.Contests)
            {
                if (item.ContestDate >= i && item.ContestDate <= f)
                {
                    contestIn.Add(item);
                }
            }
            List<string> winnersName = new List<string>();
            if (contestIn != null)
            {
                List<Round> rounds = new List<Round>();
                List<int> winnersId = new List<int>();
                for (int j = 0; j < contestIn.Count; j++)
                {
                    var aux = db.Rounds[contestIn[j].ContestNumber];
                    foreach (var item in aux)
                    {
                        rounds.Add(item);
                    }
                }
                for (int j = 0; j < rounds.Count; j++)
                {
                    var round = rounds[j];
                    for (int k = 0; k < round.GameNumber.Count; k++)
                    {
                        var game = db.Games[round.GameNumber[k] - 1];
                        var idWinner = game.WinnerParticipantNumber;
                        winnersId.Add(idWinner);
                    }

                }
                foreach (var item in winnersId)
                {
                    name = db.Players[db.Participants[item - 1].PlayerNumber - 1].PlayerName;
                    winnersName.Add(name);
                }
            }
            var temp = new List<Tuple<string, int>>();
            foreach (var item in winnersName.GroupBy(x => x))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();
            var result = new List<Tuple<string, int>>();
            foreach (var item in temp)
            {
                if (n-- == 0) break;
                result.Add(item);
            }

            return result.AsQueryable();
        }


        #endregion

        #region Query6
        public JsonResult Query6(string n)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_6 = GetQuery_6(n) } };
            return result;
        }


        private IQueryable<Tuple<string, int>> GetQuery_6(string n)
        {
            IQueryable<Participant> list = db.Participants.AsQueryable();
            list = list.Where(x => x.ContestName == n);
            var aux = list.Join(db.Decks, x => x.DeckName, d => d.DeckName, F_6).AsQueryable();
            var temp = new List<Tuple<string, int>>();
            foreach (var item in aux.GroupBy(x => x))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();
            var result = new List<Tuple<string, int>>();
            result.Add(temp[0]);
            return result.AsQueryable();
        }

        private string F_6(Participant arg1, Deck arg2)
        {
            return arg2.ArchetypeName;
        }

        #endregion

        #region Query7
        public JsonResult Query7(DateTime i, DateTime f)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_7 = GetQuery_7(i, f) } };
            return result;
        }


        private IQueryable<Tuple<string, int>> GetQuery_7(DateTime i, DateTime f)
        {
            IQueryable<Participant> list = db.Participants.AsQueryable();
            var contestIn = new List<ContestPlay>();
            foreach (var item in db.Contests)
            {
                if (item.ContestDate >= i && item.ContestDate <= f)
                {
                    contestIn.Add(item);
                }
            }

            List<int> winnersId = new List<int>();
            if (contestIn != null)
            {
                List<Round> rounds = new List<Round>();

                for (int j = 0; j < contestIn.Count; j++)
                {
                    var aux = db.Rounds[contestIn[j].ContestNumber];
                    var roundF = aux.Last();
                    var game = db.Games[roundF.GameNumber[0] - 1];
                    var idWinner = game.WinnerParticipantNumber;
                    winnersId.Add(idWinner);
                }
            }
            var winners = list.Join(winnersId, x => x.ParticipantNumber, d => d, F_9);
            var arche = winners.Join(db.Decks, x => x.DeckName, d => d.DeckName, F_7).AsQueryable();
            var temp = new List<Tuple<string, int>>();
            foreach (var item in arche.GroupBy(x => x))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();

            return temp.AsQueryable();
        }

        private string F_7(Participant arg1, Deck arg2)
        {
            return arg2.ArchetypeName;
        }

        #endregion

        #region Query8

        public JsonResult Query8(DateTime i, DateTime f)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_8 = GetQuery_8(i, f) } };
            return result;
        }


        private IQueryable<Tuple<string, string>> GetQuery_8(DateTime i, DateTime f)
        {
            IQueryable<Participant> list = db.Participants.AsQueryable();
            var contestIn = new List<ContestPlay>();
            foreach (var item in db.Contests)
            {
                if (item.ContestDate >= i && item.ContestDate <= f)
                {
                    contestIn.Add(item);
                }
            }

            List<int> winnersId = new List<int>();
            if (contestIn != null)
            {
                List<Round> rounds = new List<Round>();

                for (int j = 0; j < contestIn.Count; j++)
                {
                    var aux = db.Rounds[contestIn[j].ContestNumber];
                    var roundF = aux.Last();
                    var game = db.Games[roundF.GameNumber[0] - 1];
                    var idWinner = game.WinnerParticipantNumber;
                    winnersId.Add(idWinner);
                }
            }
            List<Player> players = new List<Player>();
            foreach (var item in winnersId)
            {
                players.Add(db.Players[db.Participants[item - 1].PlayerNumber - 1]);
            }
            var temp = new List<Tuple<string, int>>();
            var temp1 = new List<Tuple<string, int>>();
            foreach (var item in players.GroupBy(x => x.Municipality))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            foreach (var item in players.GroupBy(x => x.Province))
            {
                temp1.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();
            temp1 = temp1.OrderByDescending(x => x.Item2).ToList();
            var result = new List<Tuple<string, string>>();
            result.Add(new Tuple<string, string>(temp1.First().Item1, temp.First().Item1));

            return result.AsQueryable();
        }

        #endregion

        #region Query9

        public JsonResult Query9(string t, int r)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_9 = GetQuery_9(t, r) } };
            return result;
        }


        private IQueryable<Tuple<string, int>> GetQuery_9(string t, int r)
        {

            var temp = new List<Tuple<string, int>>();
            var contest = db.Contests.Where(x => x.ContestName == t).ToList();
            if (contest != null)
            {
                List<Round> rounds = db.Rounds[contest[0].ContestNumber];
                var partId = rounds[r].ParticipantsNumber.AsQueryable();
                IQueryable<Participant> allPart = db.Participants.AsQueryable();
                var part = allPart.Join(partId, x => x.ParticipantNumber, d => d, F_9);
                var aux = part.Join(db.Decks, x => x.DeckName, d => d.DeckName, F_6).AsQueryable();

                foreach (var item in aux.GroupBy(x => x))
                {
                    temp.Add(new Tuple<string, int>(item.Key, item.Count()));
                }
                temp = temp.OrderByDescending(x => x.Item2).ToList();

            }
            return temp.AsQueryable();
        }

        private Participant F_9(Participant arg1, int arg2)
        {
            return arg1;
        }

        #endregion

        #region Query10

        public JsonResult Query10(int n)
        {
            if (!Request.IsAjaxRequest()) { return null; }
            var result = new JsonResult { Data = new { Q_10 = GetQuery_10(n) } };
            return result;
        }


        private IQueryable<Tuple<string, int>> GetQuery_10(int n)
        {

            IQueryable<Participant> list = db.Participants.AsQueryable();
            var aux = list.Join(db.Decks, x => x.DeckName, d => d.DeckName, F_6).AsQueryable();
            var temp = new List<Tuple<string, int>>();
            foreach (var item in aux.GroupBy(x => x))
            {
                temp.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            temp = temp.OrderByDescending(x => x.Item2).ToList();
            var result = new List<Tuple<string, int>>();
            foreach (var item in temp)
            {
                if (n-- == 0) break;
                result.Add(item);
            }
            return result.AsQueryable();
        }

        #endregion
    }

}