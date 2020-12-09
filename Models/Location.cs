﻿using System.Collections.Generic;

namespace Tour.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Place { get; set; }
        public string Continent { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}