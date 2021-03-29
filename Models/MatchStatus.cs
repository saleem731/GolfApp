using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class MatchStatus
    {
        public MatchStatus()
        {
            Matches = new HashSet<Match>();
        }

        public int Id { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}
