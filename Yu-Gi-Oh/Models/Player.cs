using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class Player
    {
        [Key]
        public int PlayerNumber { get; set; }

        public string PlayerName { get; set; }

        public string Province { get; set; }

        public string Municipality { get; set; }

        public string PlayerAddress { get; set; }

        public string PhoneNumber { get; set; }

        public List<string> DecksName { get; set; }

        public int DecksCount
        {
            get
            {
                if (DecksName == null) return 0;
                return DecksName.Count;
            }
        }

    }
}