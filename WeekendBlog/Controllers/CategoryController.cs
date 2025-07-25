using Microsoft.AspNetCore.Mvc;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;

namespace WeekendBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetCategoriessAsync();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryDTO categoryDto)
        {
            if (categoryDto == null)
            {
                return BadRequest("Category data is null");
            }
            await _categoryService.AddCategoryAsync(categoryDto);
            return Ok("New Category Added");
        }
    }
}
