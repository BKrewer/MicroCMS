using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Domain.Entities
{
    public class Post : Entity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OccurrenceDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostCategoryId { get; set; }
        public PostCategory PostCategory { get; set; }

        public Post()
        {

        }
    }
}
