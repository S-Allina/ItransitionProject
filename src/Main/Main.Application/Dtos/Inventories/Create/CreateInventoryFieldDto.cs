using Main.Domain.Enums.Inventories;

namespace Main.Application.Dtos.Inventories.Create
{
    public record CreateInventoryFieldDto
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public string Description { get; init; }
        public FieldType FieldType { get; init; }
        public int OrderIndex { get; set; }
        public bool IsVisibleInTable { get; init; }
        public bool IsRequired { get; init; }
    }
}
