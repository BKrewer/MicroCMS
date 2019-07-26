using MicroCMS.Application.Web.ViewModels;
using MicroCMS.Domain.Entities;
using AutoMapper;

namespace MicroCMS.Application.Web.AutoMapper
{
    public class ApplicationMapProfile : Profile
    {
        public ApplicationMapProfile()
        {
            CreateMap<User, UserCreateRequest>()
                .ReverseMap()
                    .ForMember(x => x.Posts, opt => opt.Ignore());
            CreateMap<User, UserUpdateRequest>()
                .ReverseMap()
                    .ForMember(x => x.Posts, opt => opt.Ignore());
            CreateMap<User, UserResponse>();


            CreateMap<Post, PostCreateRequest>()
                .ReverseMap()
                    .ForMember(x => x.User, opt => opt.Ignore())
                    .ForMember(x => x.PostCategory, opt => opt.Ignore());
            CreateMap<Post, PostUpdateRequest>()
                .ReverseMap()
                    .ForMember(x => x.User, opt => opt.Ignore())
                    .ForMember(x => x.PostCategory, opt => opt.Ignore());
            CreateMap<Post, PostResponse>().ReverseMap();

            CreateMap<PostCategory, PostCategoryCreateRequest>()
                .ReverseMap();
            CreateMap<PostCategory, PostCategoryUpdateRequest>()
                .ReverseMap();
            CreateMap<PostCategory, PostCategoryResponse>()
                .ReverseMap();
        }
    }
}
