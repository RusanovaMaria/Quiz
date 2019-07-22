using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Quiz.Models
{
    public class QuestionContext : DbContext
    {
        public QuestionContext (DbContextOptions<QuestionContext> options)
            : base(options)
        {
        }

        public DbSet<Quiz.Models.Question> Question { get; set; }
    }
}
