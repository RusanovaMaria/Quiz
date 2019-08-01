using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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

                string answerWithoutSpace = answer.Trim();

                var correctAnswer = await _context.Answer.FirstOrDefaultAsync(a => a.IdQuestion == i);

                if ((correctAnswer != null) && (answerWithoutSpace.Equals(correctAnswer.Text)))
                {
                    report.PersentOfCorrectAnswers = report.PersentOfCorrectAnswers + (100 / (userAnswers.Count));
                }
            }

            saveAnswerReport(report);

            return View(report);
        }

        private void saveAnswerReport(AnswerReport report)
        {
            try
            {
                _context.AnswerReport.Add(report);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
            }
        }
    }
}