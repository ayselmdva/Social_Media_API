namespace Social_Media_API.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public AppUser? AppUser { get; set; }
        public int AppUserId { get; set; }
        public List<Media> Media { get; set; } = null!;
        public List<Like>? Likes { get; set; }
        public List<Comment>? Comments { get; set; }

    }
}
