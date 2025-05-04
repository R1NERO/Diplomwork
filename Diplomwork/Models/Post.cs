namespace Diplomwork.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string AuthorId { get; set; } = string.Empty;
        public ApplicationUser Author { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public List<Tag> Tags { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

}
