using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroCMS.Application.Web.ViewModels;
using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroCMS.Application.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCategoryController : Controller
    {
        private readonly PostCategoryService _postCategoryService;
        private readonly IMapper _mapper;

        public PostCategoryController(PostCategoryService postCategoryService, IMapper mapper)
        {
            _postCategoryService = postCategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var postCategories = await _postCategoryService.GetAllAsync();
            var postViewModel = _mapper.Map<ICollection<PostCategoryResponse>>(postCategories);
            return Ok(postViewModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var postCategory = await _postCategoryService.GetByIdAsync(id);
            if (postCategory == null)
            {
                return NotFound();
            }
            var postCategoryViewModel = _mapper.Map<PostCategoryResponse>(postCategory);
            return Ok(postCategoryViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] PostCategoryCreateRequest postCategoryCreateRequest)
        {
            var newPostCategory = _mapper.Map<PostCategory>(postCategoryCreateRequest);
            await _postCategoryService.AddAsync(newPostCategory);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = newPostCategory.Id }, newPostCategory);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] PostCategoryUpdateRequest postCategoryUpdateRequest)
        {
            var postCategory = await _postCategoryService.GetByIdAsync(id);
            if (postCategory == null)
            {
                return NotFound();
            }
            var postCategoryUpdated = _mapper.Map(postCategoryUpdateRequest, postCategory);
            await _postCategoryService.UpdateAsync(postCategoryUpdated);
            return Ok(postCategoryUpdated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var postCategory = await _postCategoryService.GetByIdAsync(id);
            if(postCategory == null)
            {
                return NotFound();
            }
            await _postCategoryService.DeleteAsync(postCategory);
            return Ok();
        }
    }
}