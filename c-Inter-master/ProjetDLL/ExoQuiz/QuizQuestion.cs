using System.Collections.Generic;

namespace ProjetDLL.ExoQuiz
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string QstText { get; set; }
        public bool IsMultiple { get; set; }
        public int NumOrder{get; set;}
        public List<QuizReponse> Reponses { get; set; }

        public QuizQuestion(string qstText, bool isMultiple, int numOrder)
        {
            QstText = qstText;
            IsMultiple = isMultiple;
            NumOrder = numOrder;
            Reponses = new List<QuizReponse>();
        }
    }
}