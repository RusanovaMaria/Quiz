using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int IdQuestion { get; set; }

        public Answer()
        {

        }

        public Answer(string Text, int IdQuestion)
        {
            this.Text = Text;
            this.IdQuestion = IdQuestion;
        }
    }
}
