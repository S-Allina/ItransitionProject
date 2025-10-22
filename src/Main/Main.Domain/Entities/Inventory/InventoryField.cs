using Main.Domain.Entities.Common;
using Main.Domain.Enums.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Entities.Inventories
{
    public class InventoryField : BaseEntity
    {
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public FieldType FieldType { get; set; }
        public int OrderIndex { get; set; }
        public bool IsVisibleInTable { get; set; }
        public bool IsRequired { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
