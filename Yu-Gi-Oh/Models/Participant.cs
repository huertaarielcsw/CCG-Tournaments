using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantNumber { get; set; }

        public int PlayerNumber { get; set; }

        public string DeckName { get; set; }

        public string ContestName { get; set; }
    }
}