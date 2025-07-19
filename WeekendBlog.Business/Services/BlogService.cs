using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;
using Microsoft.EntityFrameworkCore;

namespace WeekendBlog.Business.Services
{
    internal class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository ?? throw new ArgumentNullException(nameof(blogRepository));
        }
        public async Task AddBlogPostAsync(BlogPostDto blogPostDto)
        {
            BlogPost newPost = new()
            {
                PostId = new Guid(),
                PostBody = blogPostDto.PostBody,
                PostHeader = blogPostDto.PostHeader,
                CategoryId = blogPostDto.CategoryId,
                Tags = blogPostDto.Tags,
                CreatedAt = DateTime.Now
            };
            await _blogRepository.AddBlogPostAsync(newPost);
        }

        public async Task<IEnumerable<BlogPostDto>> GetActiveBlogPostsAsync()
        {
            var posts = await _blogRepository.GetActiveBlogPostsAsync();
            var postDtos = new List<BlogPostDto>();
            foreach (var post in posts)
            {
                var postDto = new BlogPostDto
                {
                    PostId = post.PostId,
                    PostBody = post.PostBody,
                    PostHeader = post.PostHeader,
                    CategoryId = post.CategoryId,
                    IsDeleted = post.IsDeleted,
                    Tags = post.Tags,
                    CreatedAt = post.CreatedAt,
                    UpdatedAt = post.UpdatedAt
                };
            }
            return postDtos;
        }
    }
}
