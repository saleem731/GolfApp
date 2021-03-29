using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class MatchWeather
    {
        public MatchWeather()
        {
            Matches = new HashSet<Match>();
        }

        public int Id { get; set; }
        public int MatchId { get; set; }
        public int WeatherId { get; set; }

        public virtual Weather Weather { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }
}
