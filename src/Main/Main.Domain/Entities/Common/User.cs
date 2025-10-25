using Main.Domain.Entities.Comments;
using Main.Domain.Entities.Inventories;
using Main.Domain.Entities.Items;

namespace Main.Domain.Entities.Common
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<InventoryAccess> InventoryAccesses { get; set; } = new List<InventoryAccess>();
        public ICollection<Item> CreatedItems { get; set; } = new List<Item>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
    }
}
