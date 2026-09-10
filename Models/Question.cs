namespace ExamMVC.Models;

public class Question
{
    public int Number { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Prompt { get; set; } = string.Empty;

    public string? CodeSnippet { get; set; }

    public Dictionary<string, string> Choices { get; set; } = new();

    public string CorrectLetter { get; set; } = string.Empty;

    public string Rationale { get; set; } = string.Empty;

    public string CorrectText => Choices.TryGetValue(CorrectLetter, out var text) ? text : string.Empty;
}
