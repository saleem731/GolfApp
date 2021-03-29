using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class Player
    {
        public Player()
        {
            Leagues = new HashSet<League>();
            MatchPlayers = new HashSet<MatchPlayer>();
            MatchResultPlayer1s = new HashSet<MatchResult>();
            MatchResultPlayer2s = new HashSet<MatchResult>();
            Matches = new HashSet<Match>();
            Notifications = new HashSet<Notification>();
            PlayerPreferences = new HashSet<PlayerPreference>();
            PlayerProfiles = new HashSet<PlayerProfile>();
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Handicap { get; set; }
        public int GolfClubId { get; set; }

        public virtual GolfClub GolfClub { get; set; }
        public virtual ICollection<League> Leagues { get; set; }
        public virtual ICollection<MatchPlayer> MatchPlayers { get; set; }
        public virtual ICollection<MatchResult> MatchResultPlayer1s { get; set; }
        public virtual ICollection<MatchResult> MatchResultPlayer2s { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PlayerPreference> PlayerPreferences { get; set; }
        public virtual ICollection<PlayerProfile> PlayerProfiles { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
