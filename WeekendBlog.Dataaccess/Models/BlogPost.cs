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
    public class BlogPost
    {
        [Key]
        public Guid PostId { get; set; }
        [Required]
        [MinLength(100, ErrorMessage = "Minimum 100 characters required")]
        [MaxLength(2000, ErrorMessage = "Post length should not exceed 2000 characters.")]
        public String PostBody { get; set; } = String.Empty;
        [Required]
        [MinLength(20, ErrorMessage = "Minimum 20 characters required.")]
        [MaxLength(100, ErrorMessage = "Post header should not exceed 100 characters.")]
        public String PostHeader { get; set; } = String.Empty;
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public Boolean IsDeleted { get; set; }
        public List<Guid> Tags { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? UpdatedAt { get; set; }

        //relationships
        public Category? Category { get; set; }
    }
}
