using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendBlog.Business.DTOs
{
    public class TagDto
    {
        public Guid TagId { get; set; }
        public String TagName { get; set; } = String.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
