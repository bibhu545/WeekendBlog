using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Interfaces
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllTagsAsync();
        Task AddTagAsync(Tag tag);
        Task DeleteTagAsync(Guid tagId);
        Task UpdateTagAsync(Tag tag);
    }
}
