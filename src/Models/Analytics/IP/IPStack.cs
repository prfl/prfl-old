using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Models.IP
{
    public class IPStack
    {
        public string IP { get; set; }
        public string IPv4 { get; set; }
        public string ContinentCode { get; set; }
        public string ContinentName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        
        public Location Location { get; set; }
        
    }
}
