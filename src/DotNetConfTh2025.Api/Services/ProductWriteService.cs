using DotNetConfTh2025.Api.Models;

namespace DotNetConfTh2025.Api.Services;

public class ProductWriteService : IProductWriteService
{
    public Task<NewProductItem?> SaveNewProductAsync(
        SaveProductRequest request,
        CancellationToken token
    )
    {
        // persist the request values inside a new product entity
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
        return Task.FromResult(new NewProductItem(123123L, "New Product", 90));
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
    }
}
