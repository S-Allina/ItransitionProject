using Main.Domain.Entities.Inventories;
using Main.Domain.InterfacesRepository;
using Main.Domain.InterfacesRepository.Inventories;

namespace Main.Infrastructure.DataAccess.Repositories
{
    public class InventoryFieldRepository : BaseRepository<InventoryField>, IInventoryFieldRepository
    {
        public InventoryFieldRepository(ApplicationDbContext db) : base(db) { }
    }
}
