using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendBlog.Dataaccess.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        [Required]
        public String CategoryName { get; set; } = String.Empty;
        [Required]
        public String CategoryDescription { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
