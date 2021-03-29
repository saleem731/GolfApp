using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class NotificationMetum
    {
        public NotificationMetum()
        {
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string NotificationText { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
