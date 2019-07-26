using MicroCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroCMS.Domain.Interfaces.Services
{
    public interface IPostCategoryService
    {
        Task<PostCategory> AddAsync(PostCategory entity);
        Task UpdateAsync(PostCategory entity);
        Task DeleteAsync(PostCategory entity);
        Task<PostCategory> GetByIdAsync(int id);
        Task<IEnumerable<PostCategory>> GetAllAsync();
    }
}
