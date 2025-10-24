using Main.Domain.Enums.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Dtos.Common.Search
{
    public class ItemFieldSearchResult
    {
        public int ItemId { get; set; }
        public string ItemCustomId { get; set; }
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public FieldType FieldType { get; set; }
        public string Preview => FieldValue.Length > 100 ? FieldValue.Substring(0, 100) + "..." : FieldValue;
    }
}
