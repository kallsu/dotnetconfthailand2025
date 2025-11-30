namespace DotNetConfTh2025.Api.Helpers;

public static class MyStringHelperAfterDotNet10 
{
    extension(string? value) 
    {
        public bool IsNullOrEmpty()
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
}