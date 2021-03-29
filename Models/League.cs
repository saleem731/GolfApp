using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class League
    {
        public League()
        {
            Matches = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PlayerId { get; set; }
        public int PlayTypeId { get; set; }
        public int? MaxRematchCount { get; set; }

        public virtual PlayType PlayType { get; set; }
        public virtual Player Player { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }
}
