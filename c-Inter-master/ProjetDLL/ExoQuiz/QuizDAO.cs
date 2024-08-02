using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ExoQuiz
{
    public class QuizDAO
    {
        public static Quizz QuizExemple()
        {
            Quizz quiz = new Quizz("c#");
            QuizQuestion qst1 = new QuizQuestion("Comment déclarer une contante ?", false, 1);
            qst1.Reponses.Add(new QuizReponse(true, "const TYPE NOM = valeur"));
            qst1.Reponses.Add(new QuizReponse(false, "static TYPE NOM = valeur"));

            quiz.Questions.Add(qst1);

            QuizQuestion qst2 = new QuizQuestion("Quels sont les accesseurs de visibilité en c#?", true, 2);
            qst2.Reponses.Add(new QuizReponse(true, "public"));
            qst2.Reponses.Add(new QuizReponse(false, "restricted"));
            qst2.Reponses.Add(new QuizReponse(true, "private"));
            qst2.Reponses.Add(new QuizReponse(false, "protect"));

            quiz.Questions.Add(qst2);


            return quiz;
        }
    }
}
