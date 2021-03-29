using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class PlayerPreference
    {
        public int Id { get; set; }
        public bool InAppNotifications { get; set; }
        public bool EmailNotifications { get; set; }
        public bool PromotionalEmails { get; set; }
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
    }
}
