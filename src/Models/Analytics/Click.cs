using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Profile.Models
{
    public class Click
    {
        public string ClickId { get; set; }
        public DateTime ClickDateTime { get; set; }
        public string UserId { get; set; }
        public LinkType Type { get; set; }
        public string LinkId { get; set; }
        public string PublicIP { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

    }
}
