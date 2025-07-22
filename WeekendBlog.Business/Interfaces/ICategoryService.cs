using WeekendBlog.Business.DTOs;

namespace WeekendBlog.Business.Interfaces
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(CategoryDTO category);
        Task<IEnumerable<CategoryDTO>> GetCategoriessAsync();
    }
}