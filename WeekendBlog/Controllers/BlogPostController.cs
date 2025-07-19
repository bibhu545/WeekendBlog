using Microsoft.AspNetCore.Mvc;
using WeekendBlog.Business.Interfaces;

namespace WeekendBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostController: ControllerBase
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
    }
}
