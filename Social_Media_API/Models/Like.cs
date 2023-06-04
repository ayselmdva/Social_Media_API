namespace Social_Media_API.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public Post? Post { get; set; }
        public int PostId { get; set; }
        public AppUser? AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
