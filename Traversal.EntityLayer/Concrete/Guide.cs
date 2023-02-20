﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Traversal.EntityLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string SubDescription { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status { get; set; }

        public List<Destination> Destinations { get; set; }
    }
}
