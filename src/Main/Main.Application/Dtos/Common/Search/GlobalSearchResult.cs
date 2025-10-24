using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Dtos.Common.Search
{
    public class GlobalSearchResult
    {
        public string SearchTerm { get; set; }
        public List<InventorySearchResult> Inventories { get; set; } = new();
        public List<ItemFieldSearchResult> ItemFields { get; set; } = new();
        public List<UserSearchResult> Users { get; set; } = new();
        public int TotalResults => Inventories.Count + ItemFields.Count + Users.Count;
    }
}
