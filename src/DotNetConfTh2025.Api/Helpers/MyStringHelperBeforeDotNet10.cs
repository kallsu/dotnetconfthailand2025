namespace DotNetConfTh2025.Api.Helpers;

public static class MyStringHelperBeforeDotNet10
{
    public static bool IsNullOrEmpty(string? value)
    {
        if (value == null)
        {
            return true;
        }

        if (string.IsNullOrEmpty(value))
        {
            return true;
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            return true;
        }

        return false;
    }
}
