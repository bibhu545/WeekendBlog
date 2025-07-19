using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Implementations
{
    internal class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;
        public BlogRepository(BlogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddBlogPostAsync(BlogPost blogPost)
        {
            _context.Add(blogPost);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogPost>> GetActiveBlogPostsAsync()
        {
            return await _context.BlogPosts.Where(d => !d.IsDeleted).ToListAsync();
        }
    }
}
