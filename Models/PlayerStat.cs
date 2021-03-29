using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class PlayerStat
    {
        public int? Id { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
        public int? LeagueId { get; set; }
        public int? MatchWon { get; set; }
        public int? MatchLost { get; set; }
        public int? MatchTied { get; set; }

        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
