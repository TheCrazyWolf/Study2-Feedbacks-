namespace BlazorApp3.Models;

public class Feedback
{
    public string Author { get; set; }
    public string Message { get; set; }
    public int StarsCount { get; set; }

    public Feedback(string author, string message, int starsCount)
    {
        Author = author;
        Message = message;
        StarsCount = starsCount;
    }
}