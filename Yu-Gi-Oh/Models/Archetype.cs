using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yu_Gi_Oh.Models
{
    public class Archetype
    {
        [Key]
       public string ArchetypeName { get; set; }
    }

}