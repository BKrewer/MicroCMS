using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Interfaces.Repository;
using MicroCMS.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroCMS.Domain.Services
{
    public class PostCategoryService : IPostCategoryService
    {
        private readonly IPostCategoryRepository _postCategoryRepository;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository)
        {
            _postCategoryRepository = postCategoryRepository;
        }

        public async Task<PostCategory> AddAsync(PostCategory entity)
        {
            return await _postCategoryRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(PostCategory entity)
        {
            await _postCategoryRepository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<PostCategory>> GetAllAsync()
        {
            return await _postCategoryRepository.GetAllAsync();
        }

        public async Task<PostCategory> GetByIdAsync(int id)
        {
            return await _postCategoryRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(PostCategory entity)
        {
            await _postCategoryRepository.UpdateAsync(entity);
        }
    }
}
