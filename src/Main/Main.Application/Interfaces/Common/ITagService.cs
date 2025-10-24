using Main.Application.Dtos.Inventories.Index;
using Main.Domain.Entities.Inventories;

namespace Main.Application.Interfaces.Common
{
    public interface ITagService
    {
        Task<List<TagWithCountDto>> GetAllTagsWithCountAsync(CancellationToken cancellationToken =default);
        Task<List<Tag>> GetPopularTagsAsync(int count = 50);
    }
}
