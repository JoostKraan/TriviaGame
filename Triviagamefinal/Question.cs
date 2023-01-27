using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviagamefinal
{
    public class Question
    {
        public List<Answers> Answers = new List<Answers>();
        public string Name { get; set; }

        public bool isCorrect;
    }

}
