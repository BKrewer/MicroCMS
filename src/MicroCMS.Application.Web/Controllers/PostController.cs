using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroCMS.Application.Web.ViewModels;
using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MicroCMS.Application.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly PostService _postService;
        private readonly IMapper _mapper;

        public PostController(PostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var posts = await _postService.GetAllAsync();
            var postsViewModels = _mapper.Map<IEnumerable<PostResponse>>(posts);
            return Ok(postsViewModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var post = await _postService.GetByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            var postViewModels = _mapper.Map<PostResponse>(post);
            return Ok(postViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] PostCreateRequest postCreateRequest)
        {
            var newUser = _mapper.Map<Post>(postCreateRequest);
            await _postService.AddAsync(newUser);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] PostUpdateRequest postUpdateRequest)
        {
            var post = await _postService.GetByIdAsync(id);
            if(post == null)
            {
                return NotFound();
            }
            var postUpdated = _mapper.Map(postUpdateRequest, post);
            await _postService.UpdateAsync(postUpdated);
            return Ok(postUpdated);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var post = await _postService.GetByIdAsync(id);
            if(post == null)
            {
                return NotFound();
            }
            await _postService.DeleteAsync(post);
            return Ok();
        }

    }
}