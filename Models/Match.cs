using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class Match
    {
        public Match()
        {
            MatchInvites = new HashSet<MatchInvite>();
            MatchPlayers = new HashSet<MatchPlayer>();
            MatchResults = new HashSet<MatchResult>();
            Notifications = new HashSet<Notification>();
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public int? LeagueId { get; set; }
        public int CourseId { get; set; }
        public int TeeId { get; set; }
        public int PlayTypeId { get; set; }
        public DateTime MatchDateTime { get; set; }
        public int InitiatorPlayerId { get; set; }
        public int MatchWeatherId { get; set; }
        public int MatchStatus { get; set; }

        public virtual GolfCourse Course { get; set; }
        public virtual Player InitiatorPlayer { get; set; }
        public virtual League League { get; set; }
        public virtual MatchStatus MatchStatusNavigation { get; set; }
        public virtual MatchWeather MatchWeather { get; set; }
        public virtual PlayType PlayType { get; set; }
        public virtual Tee Tee { get; set; }
        public virtual ICollection<MatchInvite> MatchInvites { get; set; }
        public virtual ICollection<MatchPlayer> MatchPlayers { get; set; }
        public virtual ICollection<MatchResult> MatchResults { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
