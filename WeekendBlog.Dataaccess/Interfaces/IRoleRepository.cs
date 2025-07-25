using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<UserRole>> GetUserRolesAsync();
        Task AddRoleAsync(UserRole role);
        Task DeleteRoleAsync(Guid roleId);
        Task UpdateRoleAsync(UserRole role);
    }
}
