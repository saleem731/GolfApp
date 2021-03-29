using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class GolfClub
    {
        public GolfClub()
        {
            GolfCourses = new HashSet<GolfCourse>();
            Players = new HashSet<Player>();
        }

        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubMembership { get; set; }
        public int TotalHoles { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public decimal Long { get; set; }
        public decimal Lat { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public int? EmailAddress { get; set; }
        public bool DrivingRange { get; set; }
        public bool PuttingGreen { get; set; }
        public bool ChippingGreen { get; set; }
        public bool PracticeBunker { get; set; }
        public bool MotorCart { get; set; }
        public bool PullCart { get; set; }
        public bool GolfClubsRental { get; set; }
        public bool ClubFitting { get; set; }
        public bool ProShop { get; set; }
        public bool GolfLessons { get; set; }
        public bool CaddieHire { get; set; }
        public bool Restaurant { get; set; }
        public bool ReceptionHall { get; set; }
        public bool ChangingRoom { get; set; }
        public bool Lockers { get; set; }
        public bool LodgingonSite { get; set; }

        public virtual ICollection<GolfCourse> GolfCourses { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
