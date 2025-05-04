using Diplomwork.Models;
using Microsoft.EntityFrameworkCore;

namespace Diplomwork.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public List<Like> Likes { get; set; } = new();
        public DbSet<Tag> Tags { get; set; } = null!;
    }

}
