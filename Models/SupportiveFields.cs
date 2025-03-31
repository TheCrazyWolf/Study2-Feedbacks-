namespace BlazorApp3.Models;

public class SupportiveFields
{
    public string SupAuthor { get; set; }
    public string SupMessage { get; set; }
    public int SupStarsCount { get; set; }
    
    public void SetValue(int num)
    {
        SupStarsCount = num;
    }
}