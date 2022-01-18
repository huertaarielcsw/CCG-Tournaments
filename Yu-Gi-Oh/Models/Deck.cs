using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class Deck
    {
        [Key]
        public string DeckName { get; set; }

        public int PlayerNumber { get; set; }

        public int MainDeck { get; set; }

        public int SideDeck { get; set; }

        public int ExtraDeck { get; set; }

        public string ArchetypeName { get; set; }
    }
}