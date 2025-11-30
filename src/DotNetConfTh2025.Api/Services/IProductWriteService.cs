using DotNetConfTh2025.Api.Models;

namespace DotNetConfTh2025.Api.Services;

public interface IProductWriteService 
{ 
    public Task<NewProductItem?> SaveNewProductAsync(SaveProductRequest request, CancellationToken token);
}
