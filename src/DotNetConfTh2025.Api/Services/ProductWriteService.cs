using DotNetConfTh2025.Api.Models;

namespace DotNetConfTh2025.Api.Services;

public class ProductWriteService : IProductWriteService
{
    public Task<NewProductItem?> SaveNewProductAsync(SaveProductRequest request, CancellationToken token)
    {
        // persist the request values inside a new product entity

        return new NewProductItem(123123L, "New Product", 90);
    }
}