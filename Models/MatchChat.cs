using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class MatchChat
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int? Player1Id { get; set; }
        public int? Player2Id { get; set; }
        public string Status { get; set; }
    }
}
