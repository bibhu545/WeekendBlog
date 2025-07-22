using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Interfaces
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> GetCategoriesAsync();
    
    }
}