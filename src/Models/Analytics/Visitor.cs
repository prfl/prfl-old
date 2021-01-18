using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Profile.Models
{
    public class Visitor
    {
        public string VisitorId { get; set; }
        public DateTime VisitedOn { get; set; }
        public string Key { get; set; } = "prfl-uid";
        public string Page { get; set; }
    }
}
