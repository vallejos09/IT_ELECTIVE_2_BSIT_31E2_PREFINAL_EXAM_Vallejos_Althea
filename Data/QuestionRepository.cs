using ExamMVC.Models;

namespace ExamMVC.Data;

public static class QuestionRepository
{
    public static List<Question> GetAll() => new()
    {
        new Question
        {
            Number = 1,
            Topic = "Data Persistence",
            Prompt = "What is the main problem solved by using a database instead of an in-memory collection?",
            Choices = new()
            {
                ["A"] = "It makes C# code shorter",
                ["B"] = "It prevents the application from restarting",
                ["C"] = "It allows data to persist after the application stops",
                ["D"] = "It removes the need for MVC"
            },
            CorrectLetter = "C",
            Rationale = "An in-memory list disappears the moment the process ends. A database keeps the data on disk, so it survives restarts, deployments, and crashes."
        },

    };
}
