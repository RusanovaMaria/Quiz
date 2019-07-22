using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Question()
        {

        }

        public Question(string Text)
        {
            this.Text = Text;
        }

    }
}

