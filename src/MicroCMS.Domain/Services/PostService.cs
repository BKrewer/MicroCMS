using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Interfaces.Repository;
using MicroCMS.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroCMS.Domain.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Post> AddAsync(Post entity)
        {
            return await _postRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(Post entity)
        {
            await _postRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Post entity)
        {
            await _postRepository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _postRepository.GetAllAsync();
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _postRepository.GetByIdAsync(id);
        }
    }
}
