using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class MatchResult
    {
        public int Id { get; set; }
        public int? LeagueId { get; set; }
        public int MatchId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int WinnerId { get; set; }
        public int LoserId { get; set; }
        public bool? IsTied { get; set; }

        public virtual Match Match { get; set; }
        public virtual Player Player1 { get; set; }
        public virtual Player Player2 { get; set; }
    }
}
