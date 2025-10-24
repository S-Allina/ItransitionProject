using Microsoft.AspNetCore.Http;

namespace Main.Application.Interfaces.External
{
    public interface IImgBBStorageService
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}
