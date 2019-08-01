﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quiz.Models;

namespace Quiz.Models
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options)
            : base(options)
        {
        }

        public DbSet<Quiz.Models.Question> Question { get; set; }
        public DbSet<Quiz.Models.Answer> Answer { get; set; }
        public DbSet<Quiz.Models.AnswerReport> AnswerReport { get; set; }
      
    }
}
