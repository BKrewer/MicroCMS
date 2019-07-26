using MicroCMS.Domain.Entities;
using System;

namespace MicroCMS.Application.Web.ViewModels
{
    public class PostCreateRequest
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OccurrenceDate { get; set; }
        public int UserId { get; set; }
        public int PostCategoryId { get; set; }
    }

    public class PostUpdateRequest
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OccurrenceDate { get; set; }
        public int UserId { get; set; }
        public int PostCategoryId { get; set; }
    }

    public class PostResponse
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OccurrenceDate { get; set; }
        public int UserId { get; set; }
        public int PostCategoryId { get; set; }
    }
}
