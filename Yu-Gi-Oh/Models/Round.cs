using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class Round
    {
        [Key]
        public int RoundNumber { get; set; }

        public Type Type { get; set; }

        public string ClassificationRoundNumber { get; set; }

        public string EliminationRoundNumber { get; set; }

        public List<int> GameNumber { get; set; }

        public List<int> ParticipantsNumber { get; set; }
    }

    public enum Type { Classification, Elimination}
}