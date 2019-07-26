using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Interfaces.Repository;
using MicroCMS.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroCMS.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddAsync(User entity)
        {

            return await _userRepository.AddAsync(entity);
        }
        
        public async Task UpdateAsync(User entity)
        {
            await  _userRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(User entity)
        {
            await _userRepository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

    }
}
