using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class AnswerController : Controller
    {
        public ActionResult Submit()
        {

            var requestForm = Request.Form;
            var name = requestForm["Name"];
            var report = new AnswerReport();
            report.Name = name;
            return View(report);
        }

    }
}