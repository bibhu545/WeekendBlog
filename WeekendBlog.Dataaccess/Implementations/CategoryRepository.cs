using Microsoft.EntityFrameworkCore;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Interfaces
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly BlogContext _context;
        public CategoryRepository(BlogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddCategoryAsync(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.Where(c => c.IsActive).ToListAsync();
        }
    }
}