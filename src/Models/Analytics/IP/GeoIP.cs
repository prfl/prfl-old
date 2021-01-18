using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Models.IP
{
    public class GeoIP
    {
        public string IP { get; set; }
        public string ISP { get; set; }
        public string Org { get; set; }
        public string Hostname { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country_Code { get; set; }
        public string Country_Name { get; set; }
        public string ContinentName { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string TimezoneName { get; set; }
        public string ConnectionType { get; set; }
        public int AsnNumber { get; set; }
        public string AsnOrg { get; set; }
        public string ASN { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public bool Success { get; set; }
        public bool Premium { get; set; }        
    }
}
