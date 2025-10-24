using Main.Application.Dtos.Inventories.Index;
using Main.Application.Interfaces;
using Main.Application.Interfaces.Common;
using Main.Domain.Entities.Inventories;
using Main.Domain.InterfacesRepository.Inventories;
using System.Linq;

namespace Main.Application.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<TagWithCountDto>> GetAllTagsWithCountAsync(CancellationToken cancellationToken)
        {
            var tags = await _tagRepository.GetAllAsync();

            return tags.Select(t => new TagWithCountDto
            {
                TagId = t.Id,
                Name = t.Name,
                InventoryCount = t.InventoryTags.Count(),
                TotalUsageCount = t.InventoryTags.Count()
            })
            .Where(t => t.InventoryCount > 0)
            .OrderByDescending(t => t.InventoryCount)
            .ToList(cancellationToken);
        }

        public async Task<List<Tag>> GetPopularTagsAsync(int count = 50)
        {
            var tags = await _tagRepository.GetAllAsync();
            return tags.OrderByDescending(t => t.InventoryTags.Count())
            .Take(count)
            .ToList();
        }
    }
}
