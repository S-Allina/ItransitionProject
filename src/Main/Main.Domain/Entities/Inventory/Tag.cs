using Main.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Entities.Inventories
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<InventoryTag> InventoryTags { get; set; }
    }
}
