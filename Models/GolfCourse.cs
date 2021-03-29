using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class GolfCourse
    {
        public GolfCourse()
        {
            Matches = new HashSet<Match>();
            Tees = new HashSet<Tee>();
            Weathers = new HashSet<Weather>();
        }

        public int CourseId { get; set; }
        public int ClubId { get; set; }
        public string CourseName { get; set; }
        public int Holes { get; set; }
        public int Par { get; set; }
        public string CourseType { get; set; }
        public string CourseArchitect { get; set; }
        public string OpenDate { get; set; }
        public bool? GuestPolicy { get; set; }
        public float? WeekdayPrice { get; set; }
        public float? WeekendPrice { get; set; }
        public float? TwilightPrice { get; set; }
        public string Fairway { get; set; }
        public string Green { get; set; }
        public string Currency { get; set; }
        public int WeatherId { get; set; }
        public decimal CourseHandicap { get; set; }

        public virtual GolfClub Club { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
        public virtual ICollection<Tee> Tees { get; set; }
        public virtual ICollection<Weather> Weathers { get; set; }
    }
}
