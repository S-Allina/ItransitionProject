namespace Main.Application.Dtos.Inventories.Index
{
    public record TagWithCountDto
    {
        public int TagId { get; init; }
        public string Name { get; init; }
        public int InventoryCount { get; init; }
        public int TotalUsageCount { get; init; }
    }
}
