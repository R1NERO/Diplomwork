namespace Diplomwork.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string AuthorId { get; set; } = string.Empty;
        public ApplicationUser Author { get; set; } = null!;
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
