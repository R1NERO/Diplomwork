﻿namespace Diplomwork.Models
{
    public class Like
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;
    }

}
