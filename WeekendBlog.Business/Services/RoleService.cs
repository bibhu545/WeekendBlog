using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Business.Services
{
    internal class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository) 
        {
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }
        public async Task AddRoleAsync(UserRoleDto roleDto)
        {
            UserRole role = new UserRole
            {
                RoleName = roleDto.RoleName,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };
            await _roleRepository.AddRoleAsync(role);
        }

        public Task DeleteRoleAsync(Guid roleid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoleAsync(UserRoleDto role)
        {
            throw new NotImplementedException();
        }
    }
}
