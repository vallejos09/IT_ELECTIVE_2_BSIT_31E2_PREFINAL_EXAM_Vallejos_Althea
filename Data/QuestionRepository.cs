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
        new Question
        {
            Number = 2,
            Topic = "EF Core Workflows",
            Prompt = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
            Choices = new()
            {
                ["A"] = "Code-First",
                ["B"] = "Database-First",
                ["C"] = "Model-First",
                ["D"] = "Controller-First"
            },
            CorrectLetter = "B",
            Rationale = "Database-First reverses the usual flow: the schema already exists, and EF Core's scaffolding tool reads it to generate matching C# classes."
        },
        new Question
        {
            Number = 3,
            Topic = "EF Core Fundamentals",
            Prompt = "What is the primary purpose of Entity Framework Core?",
            Choices = new()
            {
                ["A"] = "To create HTML pages automatically",
                ["B"] = "To replace the MVC Controller",
                ["C"] = "To map objects in code to relational database data",
                ["D"] = "To replace the C# compiler"
            },
            CorrectLetter = "C",
            Rationale = "EF Core is an Object-Relational Mapper (ORM) — its whole job is translating between C# objects and relational rows/tables."
        },
        new Question
        {
            Number = 4,
            Topic = "EF Core Fundamentals",
            Prompt = "Which EF Core component is primarily responsible for communicating with the database?",
            Choices = new()
            {
                ["A"] = "DbContext",
                ["B"] = "DbSetView",
                ["C"] = "ControllerContext",
                ["D"] = "RazorContext"
            },
            CorrectLetter = "A",
            Rationale = "DbContext represents the session with the database — it tracks entities, builds queries, and commits changes on SaveChanges()."
        },
        new Question
        {
            Number = 5,
            Topic = "EF Core Tooling",
            Prompt = "What does the following command primarily do?",
            CodeSnippet = "dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
            Choices = new()
            {
                ["A"] = "Deletes the database",
                ["B"] = "Creates a new MVC project",
                ["C"] = "Generates EF Core models and a DbContext from an existing database",
                ["D"] = "Starts the MVC application"
            },
            CorrectLetter = "C",
            Rationale = "This is the Database-First scaffolding command — it inspects the connection string's schema and writes matching entity classes and a DbContext into the Models folder."
        },
        new Question
        {
            Number = 6,
            Topic = "Configuration",
            Prompt = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
            Choices = new()
            {
                ["A"] = "Program.cs only",
                ["B"] = "appsettings.json",
                ["C"] = "Index.cshtml",
                ["D"] = "Student.cs"
            },
            CorrectLetter = "B",
            Rationale = "appsettings.json is the standard configuration file — it keeps connection strings out of code and lets each environment override them."
        },
    };
}
