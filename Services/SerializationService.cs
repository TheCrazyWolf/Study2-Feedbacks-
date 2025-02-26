using BlazorApp3.Models;
using Newtonsoft.Json;

namespace BlazorApp3.Services;

public class SerializationService
{
    public List<Feedback> Feedbacks = [];
    public string path = "feedbacks.json";
    
    public void OpenFile()
    {
        if (File.Exists(path))
        {
            var json = File.ReadAllText(path);
            Feedbacks = JsonConvert.DeserializeObject<List<Feedback>>(json)!;
        }
        else
        {
            SaveFile();
        }
    }

    public void SaveFile()
    {
        var json = JsonConvert.SerializeObject(Feedbacks);
        File.WriteAllText(path, json);
    }

    public void DeleteFeedback(Feedback item)
    {
        Feedbacks.Remove(item);
        SaveFile();
    }

    public void AddFeedback(Feedback obj)
    {
        Feedbacks.Add(obj);
        SupportiveFields.SupAuthor = string.Empty;
        SupportiveFields.SupMessage = string.Empty;
        SupportiveFields.SupStarsCount = 0;
        
        SaveFile();
    }
}