using MicroCMS.Domain.Interfaces.Repository;
using MicroCMS.Domain.Services;
using MicroCMS.Infra.Data;
using MicroCMS.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<PostService>();
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<PostCategoryService>();
            services.AddTransient<IPostCategoryRepository, PostCategoryRepository>();

            services.AddScoped<DbInitializer>();
        }
    }
}
