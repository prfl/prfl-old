using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Models
{

    public class Video
    {
        public string VideoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifedOn { get; set; }
        public string ProfileUserId { get; set; }
        public ProfileUser ProfileUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsFavorite { get; set; }
    }
}
