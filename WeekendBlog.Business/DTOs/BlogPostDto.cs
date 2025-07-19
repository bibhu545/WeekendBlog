using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Business.DTOs
{
    public class BlogPostDto
    {
        public Guid PostId { get; set; }
        public String PostBody { get; set; } = String.Empty;
        public String PostHeader { get; set; } = String.Empty;
        public Guid CategoryId { get; set; }
        public Boolean IsDeleted { get; set; }
        public List<Guid> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
