using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Business.Services
{
    internal class TagService : ITagService
    {
        private readonly ITagRepository _tagReposiroty;
        public TagService(ITagRepository tagRepository)
        {
            _tagReposiroty = tagRepository ?? throw new ArgumentNullException(nameof(tagRepository));
        }
        public async Task AddTagAsync(TagDto tag)
        {
            Tag tagModel = new()
            {
                TagId = Guid.NewGuid(),
                TagName = tag.TagName
            };
            await _tagReposiroty.AddTagAsync(tagModel);
        }

        public Task DeleteTagAsync(Guid tagId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagDto>> GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTagAsync(TagDto tag)
        {
            throw new NotImplementedException();
        }
    }
}
