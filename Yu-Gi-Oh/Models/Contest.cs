using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yu_Gi_Oh.Models
{
    public class ContestPlay
    {
        [Key]
        public string ContestName { get; set; }
        public int ContestNumber { get; set; }

        public string ContestAddress { get; set; }

        public DateTime ContestDate { get; set; }

        public List<int> RoundNumber { get; set; }

        public List<int> ParticipantsNumber { get; set; }
    }
}