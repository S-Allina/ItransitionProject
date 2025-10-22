using Main.Domain.Entities.Common;
using Main.Domain.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Entities.Comments
{
    public class Like : BaseEntity
    {
        public int ItemId { get; set; }
        public Item Item { get; set; } = new Item();
        public string UserId { get; set; } = string.Empty;
        public DateTime LikedAt { get; set; } = DateTime.UtcNow;
    }
}
