using System.ComponentModel.DataAnnotations;

namespace DotNetConfTh2025.Api.Models;

public record NewProductItem(
    //#GGO-CASE: validation for the reponse using the data annotation
    [Range(1, long.MaxValue)] long ProductId,
    [Required(AllowEmptyStrings = false)] string ProductName,
    [Range(0, 100)] int Stock
) { }
