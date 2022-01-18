using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class EliminationRound:Round
    {
        public List<int> GamesElimination { get; set; }
    }
}