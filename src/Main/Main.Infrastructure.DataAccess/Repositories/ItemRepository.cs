using Main.Domain.Entities.Items;
using Main.Domain.InterfacesRepository;
using Main.Domain.InterfacesRepository.Items;
using Microsoft.EntityFrameworkCore;

namespace Main.Infrastructure.DataAccess.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext db) : base(db) { }

        public async Task<Item> UpdateItemAsync(Item item, CancellationToken cancellationToken = default)
        {
                var existingItem = await _db.Set<Item>()
                    .FirstOrDefaultAsync(i => i.Id == item.Id, cancellationToken);

                if (existingItem == null)
                    throw new Exception("Item not found");

                _db.Entry(existingItem).CurrentValues.SetValues(item);
                await _db.SaveChangesAsync(cancellationToken);
                return existingItem;
        }
    }
}
