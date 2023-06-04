namespace Social_Media_API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public DateTime Time { get; set; }
        public Post? Post { get; set; }
        public int PostId { get; set; }
        public AppUser? AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
