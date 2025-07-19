using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;

namespace WeekendBlog.Business.Interfaces
{
    public interface IBlogService
    {
        Task AddBlogPostAsync(BlogPostDto blogPostDto);
        Task<IEnumerable<BlogPostDto>> GetActiveBlogPostsAsync();
    }
}
