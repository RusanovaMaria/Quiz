﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class AnswerReportsController : Controller
    {
        private readonly QuizContext _context;

        public AnswerReportsController(QuizContext context)
        {
            _context = context;
        }

        // GET: AnswerReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnswerReport.ToListAsync());
        }

        // GET: AnswerReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerReport = await _context.AnswerReport
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answerReport == null)
            {
                return NotFound();
            }

            return View(answerReport);
        }

        // GET: AnswerReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnswerReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PersentOfCorrectAnswers")] AnswerReport answerReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(answerReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(answerReport);
        }

        // GET: AnswerReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerReport = await _context.AnswerReport.FindAsync(id);
            if (answerReport == null)
            {
                return NotFound();
            }
            return View(answerReport);
        }

        // POST: AnswerReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PersentOfCorrectAnswers")] AnswerReport answerReport)
        {
            if (id != answerReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answerReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerReportExists(answerReport.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(answerReport);
        }

        // GET: AnswerReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerReport = await _context.AnswerReport
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answerReport == null)
            {
                return NotFound();
            }

            return View(answerReport);
        }

        // POST: AnswerReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var answerReport = await _context.AnswerReport.FindAsync(id);
            _context.AnswerReport.Remove(answerReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerReportExists(int id)
        {
            return _context.AnswerReport.Any(e => e.Id == id);
        }
    }
}
