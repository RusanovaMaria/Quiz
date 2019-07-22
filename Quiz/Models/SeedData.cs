using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuestionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuestionContext>>()))
            {
                if (context.Question.Any())
                {
                    return;   // DB has been seeded
                }

                context.Question.AddRange(
                    new Question
                    {
                        Text = "В каком году отменили крепостное право?"
                    },

                     new Question
                     {
                         Text = "Год начала правления Михаила Романова?"
                     },

                    new Question
                    { 
                        Text = "Сколько существует цветов радуги?"
                    },

                    new Question
                    { 
                        Text = "Сколько лет было Пушкину на момент смерти?"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
