using Main.Domain.Entities.Common;
using Main.Domain.Entities.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Entities.Comments
{
    public class Comment : BaseEntity
    {
        public int InventoryId { get; set; } = 0;
        public Inventory Inventory { get; set; } = new Inventory();
        public string AuthorId { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; 
    }
}
