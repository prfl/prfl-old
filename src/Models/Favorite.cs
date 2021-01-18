using System;

namespace Profile.Models
{
    public enum LinkType {
        Account,
        Article,
        Link,
        Post,
        Project,
        Video
    }
    public class Favorite
    {
        public string FavoriteId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ModifedOn { get; set; } = DateTime.Now;

        public string LinkId { get; set; }
        public string ProfileUserId { get; set; }
        public ProfileUser ProfileUser { get; set; }
        public LinkType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        
    }
}
