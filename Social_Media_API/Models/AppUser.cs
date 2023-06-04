using Microsoft.AspNetCore.Identity;

namespace Social_Media_API.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
        public List<FriendShip>? Friendships { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Post>? Posts { get; set; }
        public List<Media>? Media { get; set; }
    }
}
