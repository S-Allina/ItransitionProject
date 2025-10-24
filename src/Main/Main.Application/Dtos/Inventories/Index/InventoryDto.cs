using Main.Application.Dtos.Inventories.Index;
using Main.Application.Helpers;

namespace Main.Application.Dtos
{
    public record InventoryDto : CreateInventoryDto
    {
        public int Id { get; init; }
        public string DescriptionHtml => MarkdownHelper.ConvertToHtml(Description);
        public string DescriptionPreview => MarkdownHelper.TruncateWithMarkdown(Description);
        public string OwnerId { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}
