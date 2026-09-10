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
        new Question
        {
            Number = 7,
            Topic = "Relational Data Modeling",
            Prompt = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
            Choices = new()
            {
                ["A"] = "One-to-One",
                ["B"] = "One-to-Many",
                ["C"] = "Many-to-Many",
                ["D"] = "Many-to-One only"
            },
            CorrectLetter = "B",
            Rationale = "One Section relates to many Students, so from Section's side it is a One-to-Many relationship (equivalently Many-to-One from Student's side)."
        },
        new Question
        {
            Number = 8,
            Topic = "Relational Data Modeling",
            Prompt = "In the following example, what is SectionId?",
            CodeSnippet = "public int SectionId { get; set; }\npublic Section Section { get; set; }",
            Choices = new()
            {
                ["A"] = "Primary key of Student",
                ["B"] = "Foreign key referencing Section",
                ["C"] = "Navigation property",
                ["D"] = "Database connection string"
            },
            CorrectLetter = "B",
            Rationale = "SectionId is the scalar column that points back to Section's primary key — the Section property beneath it is the navigation property, not this one."
        },
        new Question
        {
            Number = 9,
            Topic = "Relational Data Modeling",
            Prompt = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
            Choices = new()
            {
                ["A"] = "It stores the database password",
                ["B"] = "It represents a relationship to another entity",
                ["C"] = "It creates a new database",
                ["D"] = "It validates the student's name"
            },
            CorrectLetter = "B",
            Rationale = "Navigation properties let you walk from one entity to its related entity/entities in code, mirroring the relationship defined by the foreign key."
        },
        new Question
        {
            Number = 10,
            Topic = "Querying with EF Core",
            Prompt = "What does .Include() generally allow EF Core to do?",
            Choices = new()
            {
                ["A"] = "Delete the Section table",
                ["B"] = "Load related Section data together with Students",
                ["C"] = "Create a new Student",
                ["D"] = "Validate Student input"
            },
            CorrectLetter = "B",
            Rationale = "Include() performs eager loading — it tells EF Core to pull the related entity in the same query instead of leaving the navigation property empty."
        },
        new Question
        {
            Number = 11,
            Topic = "Razor & View Design",
            Prompt = "Why might a ViewModel be used when displaying Student and Section information?",
            Choices = new()
            {
                ["A"] = "To replace the database",
                ["B"] = "To combine or shape the data specifically needed by the view",
                ["C"] = "To automatically create database tables",
                ["D"] = "To prevent controllers from using LINQ"
            },
            CorrectLetter = "B",
            Rationale = "A ViewModel is a purpose-built shape for one screen — it can flatten or combine fields from several entities so the view only sees what it needs."
        },
        new Question
        {
            Number = 12,
            Topic = "Querying with EF Core",
            Prompt = "Consider this query. What is the main benefit of Include(s => s.Section)?",
            CodeSnippet = "var students = _context.Students.Include(s => s.Section).ToList();",
            Choices = new()
            {
                ["A"] = "It loads the related Section navigation property",
                ["B"] = "It creates a Section object manually",
                ["C"] = "It removes the foreign key",
                ["D"] = "It prevents the query from accessing the database"
            },
            CorrectLetter = "A",
            Rationale = "Without Include(), s.Section would be null for each student unless lazy loading is configured. Include() eagerly fetches it in the same round trip."
        },
        new Question
        {
            Number = 13,
            Topic = "Validation",
            Prompt = "Which type of validation occurs in the browser before a request is sent to the server?",
            Choices = new()
            {
                ["A"] = "Database-level validation",
                ["B"] = "Client-side validation",
                ["C"] = "Server-side validation",
                ["D"] = "EF Core migration validation"
            },
            CorrectLetter = "B",
            Rationale = "Client-side validation runs in JavaScript in the browser, giving instant feedback before the form is ever submitted."
        },
    };
}
