using Main.Domain.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.InterfacesRepository.Items
{
    public interface IItemRepository : IBaseRepository<Item>
    {
        Task<Item> UpdateItemAsync(Item item, CancellationToken cancellationToken = default);
    }
}
