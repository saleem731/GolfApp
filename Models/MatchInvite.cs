using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class MatchInvite
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }
        public int IntiatorId { get; set; }
        public int ReceiverId { get; set; }
        public int InviteStatus { get; set; }
        public int MatchId { get; set; }

        public virtual Match Match { get; set; }
    }
}
