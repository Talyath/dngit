using System;
using System.Collections.Generic;
using System.Text;

namespace dngit.Core.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime Founded { get; set; }
        public string Owner { get; set; }
        public Rating Rating { get; set; }

    }
}
