using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GolfApp.Models
{
    public partial class Golf_AppContext : DbContext
    {
        public Golf_AppContext(DbContextOptions<Golf_AppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GolfClub> GolfClubs { get; set; }
        public virtual DbSet<GolfCourse> GolfCourses { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchChat> MatchChats { get; set; }
        public virtual DbSet<MatchInvite> MatchInvites { get; set; }
        public virtual DbSet<MatchPlayer> MatchPlayers { get; set; }
        public virtual DbSet<MatchResult> MatchResults { get; set; }
        public virtual DbSet<MatchStatus> MatchStatuses { get; set; }
        public virtual DbSet<MatchWeather> MatchWeathers { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationMetum> NotificationMeta { get; set; }
        public virtual DbSet<PlayType> PlayTypes { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerPreference> PlayerPreferences { get; set; }
        public virtual DbSet<PlayerProfile> PlayerProfiles { get; set; }
        public virtual DbSet<PlayerStat> PlayerStats { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Tee> Tees { get; set; }
        public virtual DbSet<Weather> Weathers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<GolfClub>(entity =>
            {
                entity.HasKey(e => e.ClubId)
                    .HasName("PK__Golf_Clu__D35058C7503836CC");

                entity.ToTable("Golf_Club");

                entity.Property(e => e.ClubId).HasColumnName("ClubID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubMembership)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClubName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lat).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.Long).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GolfCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__Golf_Cou__C92D71A794E2DD19");

                entity.ToTable("Golf_Courses");

                entity.Property(e => e.CourseArchitect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseHandicap).HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourseType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fairway)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Green)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Par).HasColumnName("PAR");

                entity.Property(e => e.WeatherId).HasColumnName("WeatherID");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.GolfCourses)
                    .HasForeignKey(d => d.ClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKGolf_Cours625184");
            });

            modelBuilder.Entity<League>(entity =>
            {
                entity.ToTable("League");

                entity.HasIndex(e => e.PlayTypeId, "UQ__League__0BEEFC3BB091D6E7")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("End Date");

                entity.Property(e => e.MaxRematchCount).HasColumnName("Max_rematch-count");

                entity.Property(e => e.PlayTypeId).HasColumnName("Play_Type_Id");

                entity.Property(e => e.PlayerId).HasColumnName("Player ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("Start Date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlayType)
                    .WithOne(p => p.League)
                    .HasForeignKey<League>(d => d.PlayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKLeague285699");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Leagues)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKLeague62843");
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.ToTable("Match");

                entity.HasIndex(e => e.PlayTypeId, "UQ__Match__0BEEFC3B825FC022")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("Course ID");

                entity.Property(e => e.InitiatorPlayerId).HasColumnName("Initiator Player ID");

                entity.Property(e => e.LeagueId).HasColumnName("League ID");

                entity.Property(e => e.MatchDateTime).HasColumnType("date");

                entity.Property(e => e.MatchWeatherId).HasColumnName("MatchWeatherID");

                entity.Property(e => e.PlayTypeId).HasColumnName("Play_Type_Id");

                entity.Property(e => e.TeeId).HasColumnName("Tee ID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch517634");

                entity.HasOne(d => d.InitiatorPlayer)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.InitiatorPlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch62011");

                entity.HasOne(d => d.League)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.LeagueId)
                    .HasConstraintName("FKMatch241969");

                entity.HasOne(d => d.MatchStatusNavigation)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.MatchStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch203592");

                entity.HasOne(d => d.MatchWeather)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.MatchWeatherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch103585");

                entity.HasOne(d => d.PlayType)
                    .WithOne(p => p.Match)
                    .HasForeignKey<Match>(d => d.PlayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch684540");

                entity.HasOne(d => d.Tee)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.TeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch400362");
            });

            modelBuilder.Entity<MatchChat>(entity =>
            {
                entity.ToTable("MatchChat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchId).HasColumnName("MatchID");

                entity.Property(e => e.Player1Id).HasColumnName("Player1_Id");

                entity.Property(e => e.Player2Id).HasColumnName("Player2_Id");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MatchInvite>(entity =>
            {
                entity.ToTable("Match_Invite");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IntiatorId).HasColumnName("Intiator_Id");

                entity.Property(e => e.InviteStatus).HasColumnName("Invite_Status");

                entity.Property(e => e.LeagueId).HasColumnName("League_Id");

                entity.Property(e => e.MatchId).HasColumnName("MatchID");

                entity.Property(e => e.ReceiverId).HasColumnName("Receiver_Id");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.MatchInvites)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch_Invi299634");
            });

            modelBuilder.Entity<MatchPlayer>(entity =>
            {
                entity.ToTable("Match Players");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchId).HasColumnName("Match ID");

                entity.Property(e => e.PlayerId).HasColumnName("Player ID");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.MatchPlayers)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch Play350825");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.MatchPlayers)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch Play285300");
            });

            modelBuilder.Entity<MatchResult>(entity =>
            {
                entity.ToTable("Match_Result");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsTied).HasColumnName("Is_Tied");

                entity.Property(e => e.LeagueId).HasColumnName("League_Id");

                entity.Property(e => e.LoserId).HasColumnName("Loser_Id");

                entity.Property(e => e.MatchId).HasColumnName("MatchID");

                entity.Property(e => e.Player1Id).HasColumnName("Player1_Id");

                entity.Property(e => e.Player2Id).HasColumnName("Player2_Id");

                entity.Property(e => e.WinnerId).HasColumnName("Winner_Id");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.MatchResults)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch_Resu26789");

                entity.HasOne(d => d.Player1)
                    .WithMany(p => p.MatchResultPlayer1s)
                    .HasForeignKey(d => d.Player1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch_Resu287624");

                entity.HasOne(d => d.Player2)
                    .WithMany(p => p.MatchResultPlayer2s)
                    .HasForeignKey(d => d.Player2Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch_Resu257833");
            });

            modelBuilder.Entity<MatchStatus>(entity =>
            {
                entity.ToTable("Match_Status");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<MatchWeather>(entity =>
            {
                entity.ToTable("Match_Weather");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchId).HasColumnName("Match_Id");

                entity.Property(e => e.WeatherId).HasColumnName("WeatherID");

                entity.HasOne(d => d.Weather)
                    .WithMany(p => p.MatchWeathers)
                    .HasForeignKey(d => d.WeatherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch_Weat96268");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchId).HasColumnName("Match ID");

                entity.Property(e => e.NotificationContent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Notification Content");

                entity.Property(e => e.NotificationTypeId).HasColumnName("Notification Type ID");

                entity.Property(e => e.ToPlayerId).HasColumnName("To Player ID");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKNotificati167212");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKNotificati753856");

                entity.HasOne(d => d.ToPlayer)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ToPlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKNotificati944750");
            });

            modelBuilder.Entity<NotificationMetum>(entity =>
            {
                entity.ToTable("Notification_Meta");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NotificationText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Notification Text");
            });

            modelBuilder.Entity<PlayType>(entity =>
            {
                entity.ToTable("Play_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchId).HasColumnName("Match_Id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GolfClubId).HasColumnName("Golf_Club_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.GolfClub)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.GolfClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPlayer847353");
            });

            modelBuilder.Entity<PlayerPreference>(entity =>
            {
                entity.ToTable("Player_Preferences");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmailNotifications).HasColumnName("Email_Notifications");

                entity.Property(e => e.InAppNotifications).HasColumnName("In_App_Notifications");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PromotionalEmails).HasColumnName("Promotional_Emails");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerPreferences)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPlayer_Pre854065");
            });

            modelBuilder.Entity<PlayerProfile>(entity =>
            {
                entity.ToTable("Player_Profile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.PlayerId).HasColumnName("Player ID");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerProfiles)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPlayer_Pro627819");
            });

            modelBuilder.Entity<PlayerStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Player_Stats");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeagueId).HasColumnName("League_Id");

                entity.Property(e => e.MatchId).HasColumnName("Match_Id");

                entity.Property(e => e.MatchLost).HasColumnName("Match_Lost");

                entity.Property(e => e.MatchTied).HasColumnName("Match_Tied");

                entity.Property(e => e.MatchWon).HasColumnName("Match_Won");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.HasOne(d => d.Match)
                    .WithMany()
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPlayer_Sta903210");

                entity.HasOne(d => d.Player)
                    .WithMany()
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPlayer_Sta263684");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.ToTable("Score");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseHandicap).HasColumnName("Course_Handicap");

                entity.Property(e => e.Fairways)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Green)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatchId).HasColumnName("Match ID");

                entity.Property(e => e.Par).HasColumnName("PAR");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PlayerScore).HasColumnName("Player_Score");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.MatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKScore325099");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKScore746147");
            });

            modelBuilder.Entity<Tee>(entity =>
            {
                entity.Property(e => e.TeeId).HasColumnName("TeeID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseParforTee).HasColumnName("CoursePARforTee");

                entity.Property(e => e.Hole10Par).HasColumnName("Hole10PAR");

                entity.Property(e => e.Hole11Par).HasColumnName("Hole11PAR");

                entity.Property(e => e.Hole12Par).HasColumnName("Hole12PAR");

                entity.Property(e => e.Hole13Par).HasColumnName("Hole13PAR");

                entity.Property(e => e.Hole14Par).HasColumnName("Hole14PAR");

                entity.Property(e => e.Hole15Par).HasColumnName("Hole15PAR");

                entity.Property(e => e.Hole16Par).HasColumnName("Hole16PAR");

                entity.Property(e => e.Hole17Par).HasColumnName("Hole17PAR");

                entity.Property(e => e.Hole18Par).HasColumnName("Hole18PAR");

                entity.Property(e => e.Hole1Par).HasColumnName("Hole1PAR");

                entity.Property(e => e.Hole2Par).HasColumnName("Hole2PAR");

                entity.Property(e => e.Hole3Par).HasColumnName("Hole3PAR");

                entity.Property(e => e.Hole4Par).HasColumnName("Hole4PAR");

                entity.Property(e => e.Hole5Par).HasColumnName("Hole5PAR");

                entity.Property(e => e.Hole6Par).HasColumnName("Hole6PAR");

                entity.Property(e => e.Hole7Par).HasColumnName("Hole7PAR");

                entity.Property(e => e.Hole8Par).HasColumnName("Hole8PAR");

                entity.Property(e => e.Hole9Par).HasColumnName("Hole9PAR");

                entity.Property(e => e.TeeColor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TeeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Tees)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTees516080");
            });

            modelBuilder.Entity<Weather>(entity =>
            {
                entity.ToTable("Weather");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GolfCourseId).HasColumnName("Golf Course ID");

                entity.HasOne(d => d.GolfCourse)
                    .WithMany(p => p.Weathers)
                    .HasForeignKey(d => d.GolfCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKWeather304944");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
