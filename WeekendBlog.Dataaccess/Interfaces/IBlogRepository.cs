using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Interfaces
{
    public interface IBlogRepository
    {
        Task<IEnumerable<BlogPost>> GetActiveBlogPostsAsync();
        Task AddBlogPostAsync(BlogPost blogPost);
    }
}
