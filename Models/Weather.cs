using System;
using System.Collections.Generic;

#nullable disable

namespace GolfApp.Models
{
    public partial class Weather
    {
        public Weather()
        {
            MatchWeathers = new HashSet<MatchWeather>();
        }

        public int Id { get; set; }
        public int? Temperature { get; set; }
        public int? Wind { get; set; }
        public int? Precipitation { get; set; }
        public int GolfCourseId { get; set; }

        public virtual GolfCourse GolfCourse { get; set; }
        public virtual ICollection<MatchWeather> MatchWeathers { get; set; }
    }
}
