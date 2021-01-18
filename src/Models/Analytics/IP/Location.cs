using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Models.IP
{
    public class Location
    {
        public int GenomeId { get; set; }
        public string Capital { get; set; }
        public Languages Language { get; set; }
        public string CountryFlag { get ; set; }
        public string CountryFlagEmoji { get; set; }
        public string CountryFlagEmojiUnicode { get; set; }
        public string CallingCode { get; set; }
        public bool IsEU { get; set; }
    }
}
