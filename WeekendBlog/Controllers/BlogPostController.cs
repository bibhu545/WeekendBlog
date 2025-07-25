using Microsoft.AspNetCore.Mvc;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;

namespace WeekendBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogService _blogService;
        public BlogPostController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = await _blogService.GetActiveBlogPostsAsync();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogPost([FromBody] BlogPostDto blogPostDto)
        {
            if (blogPostDto == null)
            {
                return BadRequest("Blog post data is null");
            }
            await _blogService.AddBlogPostAsync(blogPostDto);
            return Ok("New Blog Added");
        }
    }
}
