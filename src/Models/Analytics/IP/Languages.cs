using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Models.IP
{
    public class Languages
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Native { get; set; }
    }
}
