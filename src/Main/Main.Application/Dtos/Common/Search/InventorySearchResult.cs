using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Dtos.Common.Search
{
    public class InventorySearchResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ItemsCount { get; set; }
    }
}
