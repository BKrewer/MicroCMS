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
    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;

        public UserController(UserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var users = await _userService.GetAllAsync();
            var usersViewModels = _mapper.Map<ICollection<UserResponse>>(users);
            return Ok(usersViewModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var userViewModel = _mapper.Map<UserResponse>(user);
            return Ok(userViewModel);
        }

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="userCreateRequest"></param>
        /// <returns>Usuário</returns>
        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status201Created)]
        public async Task<IActionResult> AddAsync([FromBody] UserCreateRequest userCreateRequest)
        {
            var newUser = _mapper.Map<User>(userCreateRequest);
            await _userService.AddAsync(newUser);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] UserUpdateRequest userUpdateRequest)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var userUpdated = _mapper.Map(userUpdateRequest, user);
            await _userService.UpdateAsync(userUpdated);
            return Ok(userUpdated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            await _userService.DeleteAsync(user);
            return Ok();
        }
    }
}