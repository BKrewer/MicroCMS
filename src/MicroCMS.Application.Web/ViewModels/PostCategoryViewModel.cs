using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroCMS.Application.Web.ViewModels
{
    public class PostCategoryCreateRequest
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }

    public class PostCategoryUpdateRequest
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }

    public class PostCategoryResponse
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }

}
