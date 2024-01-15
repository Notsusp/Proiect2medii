using System;
using System.ComponentModel.DataAnnotations;
namespace JustABlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [StringLength(100000)]
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Image { get; set; }
    }
}
