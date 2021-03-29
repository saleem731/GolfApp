using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class PlayerProfile
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public DateTime? Dob { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public virtual Player Player { get; set; }
    }
}
