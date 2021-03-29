using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class PlayType
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public string Type { get; set; }

        public virtual League League { get; set; }
        public virtual Match Match { get; set; }
    }
}
