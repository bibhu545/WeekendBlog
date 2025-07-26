using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendBlog.Business.DTOs
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public String UserName { get; set; } = String.Empty;
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;
        public String Email { get; set; } = String.Empty;
        public Guid RoleId { get; set; }
        public String Token { get; set; } = String.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
