using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Models
{

    public class Account
    {
        public string AccountId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifedOn { get; set; }
        public string ProfileUserId { get; set; }
        public ProfileUser ProfileUser { get; set; }
        public string ApplicationId { get; set; }
        public Application Application { get; set; }
        public string Username { get; set; }
        public bool IsFavorite { get; set; }
    }
}
