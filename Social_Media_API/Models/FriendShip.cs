namespace Social_Media_API.Models
{
    public class FriendShip
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Time { get; set; }
        public AppUser? AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
