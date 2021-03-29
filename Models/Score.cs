using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class Score
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
        public int Hole { get; set; }
        public int Par { get; set; }
        public int Stokes { get; set; }
        public int Handicap { get; set; }
        public int Points { get; set; }
        public int Yards { get; set; }
        public int? Putts { get; set; }
        public string Fairways { get; set; }
        public string Green { get; set; }
        public int PlayerScore { get; set; }
        public int? CourseHandicap { get; set; }

        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
