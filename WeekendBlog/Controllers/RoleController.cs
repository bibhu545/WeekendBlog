using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;

namespace WeekendBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService) 
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleService.GetRolesAsync();
            return Ok(roles);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole([FromBody] UserRoleDto role)
        {
            if (string.IsNullOrEmpty(role.RoleName))
            {
                return BadRequest("Role name cannot be empty");
            }
            await _roleService.AddRoleAsync(role);
            return Ok($"Role '{role.RoleName}' added successfully");
        }
    }
}
