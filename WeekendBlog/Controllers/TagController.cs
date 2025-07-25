using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;

namespace WeekendBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;
        public TagController(ITagService tagService) 
        {
            _tagService = tagService ?? throw new ArgumentNullException(nameof(tagService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            var tags = await _tagService.GetAllTagsAsync();
            return Ok(tags);
        }

        [HttpPost]
        public async Task<IActionResult> AddTag([FromBody] TagDto tag)
        {
            if (tag == null)
            {
                return BadRequest("Tag cannot be null");
            }
            await _tagService.AddTagAsync(tag);
            return Ok("Tag Created");
        }
    }
}
