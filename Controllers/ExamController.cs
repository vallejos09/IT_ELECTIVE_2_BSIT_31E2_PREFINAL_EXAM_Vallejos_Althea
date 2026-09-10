using ExamMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExamMVC.Controllers;

public class ExamController : Controller
{
    public IActionResult Index()
    {
        var questions = QuestionRepository.GetAll();
        return View(questions);
    }

    public IActionResult Details(int id)
    {
        var question = QuestionRepository.GetAll().FirstOrDefault(q => q.Number == id);

        if (question is null)
        {
            return NotFound();
        }

        return View(question);
    }

    public IActionResult Error()
    {
        return View();
    }
}
