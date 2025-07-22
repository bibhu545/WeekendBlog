namespace WeekendBlog.Business.DTOs
{
    public class CategoryDTO
    {
        public Guid CategoryId { get; set; }
        public String CategoryName { get; set; } = String.Empty;
        public String CategoryDescription { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}