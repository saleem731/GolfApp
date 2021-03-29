using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class Tee
    {
        public Tee()
        {
            Matches = new HashSet<Match>();
        }

        public int TeeId { get; set; }
        public int CourseId { get; set; }
        public string TeeName { get; set; }
        public string TeeColor { get; set; }
        public int? CourseParforTee { get; set; }
        public int? Rating { get; set; }
        public int? Slope { get; set; }
        public int? Hole1 { get; set; }
        public int? Hole2 { get; set; }
        public int? Hole3 { get; set; }
        public int? Hole5 { get; set; }
        public int? Hole6 { get; set; }
        public int? Hole7 { get; set; }
        public int? Hole8 { get; set; }
        public int? Hole9 { get; set; }
        public int? Hole10 { get; set; }
        public int? Hole11 { get; set; }
        public int? Hole12 { get; set; }
        public int? Hole13 { get; set; }
        public int? Hole14 { get; set; }
        public int? Hole15 { get; set; }
        public int? Hole16 { get; set; }
        public int? Hole17 { get; set; }
        public int? Hole18 { get; set; }
        public int? Hole1Par { get; set; }
        public int? Hole2Par { get; set; }
        public int? Hole3Par { get; set; }
        public int? Hole4Par { get; set; }
        public int? Hole5Par { get; set; }
        public int? Hole6Par { get; set; }
        public int? Hole7Par { get; set; }
        public int? Hole8Par { get; set; }
        public int? Hole9Par { get; set; }
        public int? Hole10Par { get; set; }
        public int? Hole11Par { get; set; }
        public int? Hole12Par { get; set; }
        public int? Hole13Par { get; set; }
        public int? Hole14Par { get; set; }
        public int? Hole15Par { get; set; }
        public int? Hole16Par { get; set; }
        public int? Hole17Par { get; set; }
        public int? Hole18Par { get; set; }
        public int? Hole1Handicap { get; set; }
        public int? Hole2Handicap { get; set; }
        public int? Hole3Handicap { get; set; }
        public int? Hole4Handicap { get; set; }
        public int? Hole5Handicap { get; set; }
        public int? Hole6Handicap { get; set; }
        public int? Hole7Handicap { get; set; }
        public int? Hole8Handicap { get; set; }
        public int? Hole9Handicap { get; set; }
        public int? Hole10Handicap { get; set; }
        public int? Hole11Handicap { get; set; }
        public int? Hole12Handicap { get; set; }
        public int? Hole13Handicap { get; set; }
        public int? Hole14Handicap { get; set; }
        public int? Hole15Handicap { get; set; }
        public int? Hole16Handicap { get; set; }
        public int? Hole17Handicap { get; set; }
        public int? Hole18Handicap { get; set; }
        public int? TotalDistance { get; set; }

        public virtual GolfCourse Course { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }
}
