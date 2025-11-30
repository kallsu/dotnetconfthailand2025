using DotNetConfTh2025.Api.Helpers;

namespace DotNetConfTh2025.Api.Models;

/// <summary>
/// It is the model used to return the PRODUCT entity on the read product service.
///
/// It has the NOT BEST NAMING in the WORLD, but you can understand that it is like a DTO and not an ENTITY.
/// </summary>
public record GetProductItem
{
    public GetProductItem(long Id) => this.Id = Id;

    public long Id
    {
        get => field;
        // #GGO-CASE: Usage of the INIT method with FIELD keyword.
        //
        // I am using a record for mapping an persistent entity of a possible database.
        //
        // Yes, I am using the LONG and not GUID because of the nature of 1,2,3,4, ...
        // (ordinal relation) instead of a pseudo-random generation ( https://learn.microsoft.com/en-us/dotnet/api/system.guid.newguid?view=net-10.0#remarks )
        //
        init => field = value;
    }

    public required string Name
    {
        get => field;
        // #GGO-CASE: Show the usage of the Helper with the new C#14 feature : extension members
        //
        // Old usage
        // set => field = (MyStringHelperBeforeDotNet10.IsNullOrEmpty(value) ? value.Trim() : string.Empty);
        //
        // NEW usage
        set => field = (value.IsNullOrEmpty() ? value.Trim() : string.Empty);
    }

    public bool IsOutOfStock
    {
        get => field;
        set => field = value;
    }

    public required int StockAvailable
    {
        get => field;
        // #GGO-CASE: Here an example of the usage of the FIELD keyword when the set is a block of code.
        set
        {
            field = value;
            if (value < 1)
            {
                IsOutOfStock = true;
            }
            else
            {
                IsOutOfStock = false;
            }
        }
    }

    /// <summary>
    /// I have no idea because this method is here, but Jose Barbosa (https://th.linkedin.com/in/kidchenko) told me to do that
    /// and I trust him ;-)
    /// </summary>
    ///
    /// <returns></returns>
    public static GetProductItem Empty()
    {
        return new GetProductItem(long.MinValue) { Name = "FAKE_NAME", StockAvailable = 0 };
    }
}
