using System.ComponentModel.DataAnnotations;
using DotNetConfTh2025.Api.Services;

namespace DotNetConfTh2025.Api.Endpoints;

public static class GetProduct
{
    public static void MapGetProduct(WebApplication app)
    {
        // ------------------
        // #GGO-CASE: 3 cases
        //
        // 1- Validation (new feature) introduced in 10 version
        // 2- Custom management of the token. RequestDelegate accept only 2 params because it is minimal (https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.requestdelegate?view=aspnetcore-10.0)
        // 3- Use the normal lambda syntax to implement with minimalist code the execution
        //
        app.MapGet(
            "/api/v1/products/{productId}",
            async (
                [Required(AllowEmptyStrings = false, ErrorMessage = "ITEM_ID_NULL")] string productId, 
                IProductReadService service) =>
            {
                CancellationTokenSource cts = new CancellationTokenSource();

                var result = await service.GetProductAsync(productId, cts.Token);

                return Results.Ok(result);
            }
        );
    }
}
