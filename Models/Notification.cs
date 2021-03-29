using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int NotificationTypeId { get; set; }
        public string NotificationContent { get; set; }
        public int ToPlayerId { get; set; }

        public virtual Match Match { get; set; }
        public virtual NotificationMetum NotificationType { get; set; }
        public virtual Player ToPlayer { get; set; }
    }
}
