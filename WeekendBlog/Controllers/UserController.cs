using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;

namespace WeekendBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsers();
            return Ok(users);
        }

        [HttpPost]
        [Route("Signup")]
        public async Task<IActionResult> SignUp([FromBody] UserDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest("User data is null");
            }
            await _userService.AddUser(userDto);
            return CreatedAtAction(nameof(GetUsers), new { id = userDto.UserId }, userDto);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest("User data is null");
            }
            var token = await _userService.Login(userDto);
            if (token == null)
            {
                return Unauthorized("Invalid credentials");
            }
            return Ok(new { Token = token  });
        }
    }
}
