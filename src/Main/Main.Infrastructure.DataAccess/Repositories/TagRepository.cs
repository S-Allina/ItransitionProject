using Main.Domain.Entities.Inventories;
using Main.Domain.InterfacesRepository;
using Main.Domain.InterfacesRepository.Inventories;

namespace Main.Infrastructure.DataAccess.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(ApplicationDbContext db) : base(db) { }
    }
}
