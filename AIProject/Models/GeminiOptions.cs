namespace AIProject.Models;

public class GeminiOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public string Url { get; set; } = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent";
}