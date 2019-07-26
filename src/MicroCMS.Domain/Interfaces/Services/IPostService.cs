using MicroCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroCMS.Domain.Interfaces.Services
{
    public interface IPostService
    {
        Task<Post> AddAsync(Post entity);
        Task UpdateAsync(Post entity);
        Task DeleteAsync(Post entity);
        Task<Post> GetByIdAsync(int id);
        Task<IEnumerable<Post>> GetAllAsync();
    }
}
