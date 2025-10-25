using Main.Domain.Entities.Inventories;
using Main.Domain.InterfacesRepository;
using Main.Domain.InterfacesRepository.Inventories;

namespace Main.Infrastructure.DataAccess.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db) { }
    }
}
