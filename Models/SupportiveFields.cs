namespace BlazorApp3.Models;

public static class SupportiveFields
{
    public static string SupAuthor { get; set; }
    public static string SupMessage { get; set; }
    public static int SupStarsCount { get; set; }
    
    public static void SetValue(int num)
    {
        SupStarsCount = num;
    }
}