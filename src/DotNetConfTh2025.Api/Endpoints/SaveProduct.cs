using DotNetConfTh2025.Api.Models;
using DotNetConfTh2025.Api.Services;

namespace DotNetConfTh2025.Api.Endpoints;

public static class SaveProduct
{
    // ------------------
    // #GGO-CASE: 2 cases
    //
    // 1- Input Validation over the record as request
    // 2- Output validation over the record as response
    //
    public static void MapSaveProduct(WebApplication app) 
    {
        app.MapPost("/api/v1/products/", 
            
            async (SaveProductRequest request, IProductReadService reader, IProductWriteService writer) => 
            {
                CancellationTokenSource cts = new CancellationTokenSource();

                var newProduct = await writer.SaveNewProductAsync(request, cts.Token);

                return TypedResults.Ok(newProduct);
            });
    }
}