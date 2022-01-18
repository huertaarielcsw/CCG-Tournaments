using System.ComponentModel.DataAnnotations;

namespace Yu_Gi_Oh.Models
{
    public class Game
    {
        [Key]
        public int GameNumber { get; set; }

        //count 2
        
        public int[] ParticipantsNumber { get; set; }
        
        public int[] Results { get; set; }

        public int WinnerParticipantNumber
        {
            get
            {
                if (Results == null) return 0;
                return Results[0] > Results[1] ? ParticipantsNumber[0] : ParticipantsNumber[1];
            }
        }
    }
}