using MicroCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroCMS.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> AddAsync(User entity);
        Task UpdateAsync(User entity);
        Task DeleteAsync(User entity);
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
