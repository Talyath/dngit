using System;
using System.Collections.Generic;
using System.Text;

namespace dngit.Core.Models
{
    public enum RatingTypes
    {
        Decor = 0,
        HandDryer = 1,
        Scent = 2,
        Toilet = 3,
        WashBasin = 4,

    }

    public class Rating
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public RatingTypes Type { get; set; }
        public double Value { get; set; }
        public virtual Place Place { get; set; }
    }
}
