using Social_Media_API.Models;

namespace Social_Media_API.DTO_s.PostDTO_s
{
    public class PostCreateDTO
    {
        public string? Description { get; set; }
        public List<Media> Media { get; set; } = null!;
    }
}
