﻿using Main.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Entities.Inventories
{
    public class InventoryAccess : BaseEntity
    {
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        public string UserId { get; set; }
        public string GrantedById { get; set; }
        public DateTime GrantedAt { get; set; } = DateTime.UtcNow;

        public int AccessLevel { get; set; } = 2;
    }
}
