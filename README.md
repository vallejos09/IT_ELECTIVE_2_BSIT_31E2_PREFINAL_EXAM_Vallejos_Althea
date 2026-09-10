**Vallejos, Althea P.** — BSIT 31E2

# IT Elective 2 — Prefinal Examination

An ASP.NET Core MVC app that presents all 20 items of the Prefinal
Examination (Web Systems and Technologies) as a graded "blue book" —
an answer sheet with shaded bubbles, and a per-item index card that
reveals the reasoning behind each answer.

No database is used. Every question, choice, and answer lives in a
single in-memory list (`Data/QuestionRepository.cs`) — which is itself
a nod to item 1 of the exam, on in-memory collections vs. databases.

## Why this design

The exam is graded on paper with a No. 2 pencil, so the app borrows
that vocabulary instead of looking like a generic dashboard: ruled
blue-line paper, a red vertical margin rule, a typewriter face for the
printed questions, and a handwritten red-pen face for the graded
notes. The Index page is the answer sheet (all 20 items, shaded
bubbles); each row opens its own index card with the full choices and
a one-line rationale you reveal by tapping "Show reasoning."

## Project structure

```
ExamMVC/
├── Controllers/
│   └── ExamController.cs        Index (answer sheet) + Details (item card)
├── Data/
│   └── QuestionRepository.cs    All 20 questions, choices, answers, rationale
├── Models/
│   └── Question.cs              Plain C# model — no EF Core, no DbContext
├── Views/
│   ├── Exam/
│   │   ├── Index.cshtml         The answer sheet
│   │   ├── Details.cshtml       A single graded index card
│   │   └── Error.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/
│   ├── css/site.css             The "blue book" theme
│   └── js/site.js               Reveal/hide the rationale
└── Program.cs
```

## Running it locally

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download).

```bash
cd ExamMVC
dotnet restore
dotnet run
```

Then open the URL printed in the console (typically
`https://localhost:5001` or `http://localhost:5000`).

## Answer key at a glance

| No. | Topic | Answer |
|----:|-------|:------:|
| 1 | Data Persistence | C |
| 2 | EF Core Workflows | B |
| 3 | EF Core Fundamentals | C |
| 4 | EF Core Fundamentals | A |
| 5 | EF Core Tooling | C |
| 6 | Configuration | B |
| 7 | Relational Data Modeling | B |
| 8 | Relational Data Modeling | B |
| 9 | Relational Data Modeling | B |
| 10 | Querying with EF Core | B |
| 11 | Razor & View Design | B |
| 12 | Querying with EF Core | A |
| 13 | Validation | B |
| 14 | Validation | A |
| 15 | Data Normalization & Integrity | B |
| 16 | Data Normalization & Integrity | A |
| 17 | Error Handling | B |
| 18 | Error Handling | B |
| 19 | Error Handling | B |
| 20 | Data Integrity | A |

Full reasoning for each item is in the app itself — open an item and
tap **Show reasoning**.

## Commit history

This repository was built with 20+ commits, one per exam item, on top
of an initial scaffold and styling pass — see the commit log for the
build order.
