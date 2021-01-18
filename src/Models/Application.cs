using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Models
{

    public class Application
    {
        public string ApplicationId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifedOn { get; set; }
        public string Name { get; set; }
        public string LogoLink { get; set; }
        public string ApplicationLink { get; set; }
        public string ApplicationUserLink { get; set; }
        public string BackgroundColor { get; set; }
        public string TextColor { get; set; }
    }
}
