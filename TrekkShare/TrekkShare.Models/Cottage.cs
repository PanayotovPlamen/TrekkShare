﻿namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using NetTopologySuite.Geometries;

    public class Cottage
    {
        public int CottageId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public int GeoLocationId { get; set; }
        public Point GeoLocation { get; set; }
    }
}