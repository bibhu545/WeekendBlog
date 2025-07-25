using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;

namespace WeekendBlog.Business.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsers();
        Task AddUser(UserDto userDto);
        Task<UserDto> Login(UserDto userDto);
    }
}
