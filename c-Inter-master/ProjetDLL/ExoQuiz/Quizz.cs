using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ExoQuiz
{
    public class Quizz
    {
        public int Id { get; set; }
        public string Sujet { get; set; }
        public List<QuizQuestion> Questions { get; set; }

        public Quizz(string sujet)
        {
            Sujet = sujet;
            Questions = new List<QuizQuestion>();
        }
    }
}
