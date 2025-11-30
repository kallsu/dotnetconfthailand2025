using DotNetConfTh2025.Api.Models;

namespace DotNetConfTh2025.Api.Services;

public interface IProductReadService 
{
    public Task<GetProductItem?> GetProductAsync(string productId, CancellationToken token);
}
