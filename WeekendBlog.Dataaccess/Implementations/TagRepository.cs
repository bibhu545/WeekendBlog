using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Dataaccess.Implementations
{
    internal class TagRepository : ITagRepository
    {
        public Task AddTagAsync(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTagAsync(Guid tagId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tag>> GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTagAsync(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
