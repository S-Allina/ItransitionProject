namespace Main.Application.Interfaces.Inventories
{
    public interface ICustomIdService
    {
        Task<string> GenerateCustomIdAsync(int inventoryId);
        Task<bool> ValidateCustomIdAsync(int inventoryId, string customId);
    }
}
