using System.ComponentModel.DataAnnotations;

namespace DotNetConfTh2025.Api.Models;

public record SaveProductRequest(

    // #GGO-CASE: Validation for the record as simple HTTP request
    [Required(AllowEmptyStrings=false, ErrorMessage ="PRODUCT_NAME_NULL")] string Name, 

    [Range(0, 100)] int StockAvailable)
{
}