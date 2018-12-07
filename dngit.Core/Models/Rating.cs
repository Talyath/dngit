using System;
using System.Collections.Generic;
using System.Text;

namespace dngit.Core.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int OverAllRating { get; set; }
        public List<RatingValue> Ratings { get; set; }
    }
}
