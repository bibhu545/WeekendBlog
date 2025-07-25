using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendBlog.Dataaccess.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        [MaxLength(12, ErrorMessage = "Maximum length should not exceed 12 characters")]
        public String UserName { get; set; } = String.Empty;
        [Required]
        public String FirstName { get; set; } = String.Empty;
        [Required]
        public String LastName { get; set; } = String.Empty;
        [Required]
        public String Password { get; set; } = String.Empty;
        [Required]
        [EmailAddress(ErrorMessage = "Not a valid Email")]
        public String Email { get; set; } = String.Empty;
        [Required]
        public Guid RoleId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public UserRole? Role { get; set; }
    }
}
