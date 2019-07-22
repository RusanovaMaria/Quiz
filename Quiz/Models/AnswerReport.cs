using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class AnswerReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersentOfCorrectAnswers { get; set; }

        public AnswerReport()
        {

        }

        public AnswerReport(string Name, int PersentOfCorrectAnswers)
        {
            this.Name = Name;
            this.PersentOfCorrectAnswers = PersentOfCorrectAnswers;
        }

        public AnswerReport(int Id, string Name, int PersentOfCorrectAnswers)
        {
            this.Id = Id;
            this.Name = Name;
            this.PersentOfCorrectAnswers = PersentOfCorrectAnswers;
        }
    }
}
