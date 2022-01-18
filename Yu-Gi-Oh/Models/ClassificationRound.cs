using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class ClassificationRound : Round
    {
        public List<int> GamesClassification { get; set; }

        public List<Tuple<int, int>> Participant_Puntuation { get; set; }
    }
}