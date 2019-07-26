using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Domain.Entities
{
    public class PostCategory : Entity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
