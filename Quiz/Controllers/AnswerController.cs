using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;
using Microsoft.EntityFrameworkCore;

namespace Quiz.Controllers
{
    public class AnswerController : Controller
    {

        private readonly QuizContext _context;

        public AnswerController(QuizContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Submit()
        {

            var requestForm = Request.Form;
            var name = requestForm["Name"];
            var report = new AnswerReport();
            report.Name = name;

            var userAnswers = requestForm["Answer"];

            int i = 0;

            foreach (string answer in userAnswers)
            {
                i++;

                var correctAnswer = await _context.Answer.FirstOrDefaultAsync(a => a.IdQuestion == i);

                if ((correctAnswer != null) && (answer.Equals(correctAnswer.Text)))
                {
                    report.PersentOfCorrectAnswers = report.PersentOfCorrectAnswers + (100 / (userAnswers.Count));
                }
            }

            return View(report);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}