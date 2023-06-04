using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Media_API.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string? MediaType { get; set; }
        public Post? Post { get; set; }
        public int PostId { get; set; }
        public AppUser? AppUser { get; set; }
        public int AppUserId { get; set; }
        public string? MediaUrl { get; set; }
        [NotMapped]
        public IFormFile? MediaFile { get; set; }
      

    }
}
