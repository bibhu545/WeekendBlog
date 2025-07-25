using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;

namespace WeekendBlog.Business.Interfaces
{
    public interface ITagService
    {
        Task<IEnumerable<TagDto>> GetAllTagsAsync();
        Task AddTagAsync(TagDto tag);
        Task DeleteTagAsync(Guid tagId);
        Task UpdateTagAsync(TagDto tag);
    }
}
