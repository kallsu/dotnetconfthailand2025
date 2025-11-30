using DotNetConfTh2025.Api.Models;

namespace DotNetConfTh2025.Api.Services;

public class ProductReadService : IProductReadService
{
    private readonly ILogger<ProductReadService> _logger;

    public ProductReadService(ILogger<ProductReadService> logger)
    {
        _logger = logger;
    }

    public Task<GetProductItem?> GetProductAsync(string productId, CancellationToken token)
    {
        var product = new GetProductItem(long.Parse(productId)) 
        { 
            Name = productId,
            StockAvailable = 100
        };

        //
        // I silent the warning in order to have a proper signature of the method.
        //
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
        return Task.FromResult(product);
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
    }
}
