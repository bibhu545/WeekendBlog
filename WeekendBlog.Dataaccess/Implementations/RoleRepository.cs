using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Implementations
{
    internal class RoleRepository : IRoleRepository
    {
        private readonly BlogContext _context;
        public RoleRepository(BlogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddRoleAsync(UserRole role)
        {
            _context.UserRoles.Add(role);
            await _context.SaveChangesAsync();
        }

        public Task DeleteRoleAsync(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserRole>> GetUserRolesAsync()
        {
            return await _context.UserRoles.Where(r => r.IsActive).ToListAsync();
        }

        public Task UpdateRoleAsync(UserRole role)
        {
            throw new NotImplementedException();
        }
    }
}
