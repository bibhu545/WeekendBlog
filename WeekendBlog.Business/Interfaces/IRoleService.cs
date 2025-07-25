using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;

namespace WeekendBlog.Business.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<string>> GetRolesAsync();
        Task AddRoleAsync(UserRoleDto roleName);
        Task DeleteRoleAsync(Guid roleid);
        Task UpdateRoleAsync(UserRoleDto role);
    }
}
