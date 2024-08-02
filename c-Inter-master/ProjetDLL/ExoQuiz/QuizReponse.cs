namespace ProjetDLL.ExoQuiz
{
    public class QuizReponse
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string RepText { get; set; }

        public QuizReponse(bool isCorrect, string repText)
        {
            IsCorrect = isCorrect;
            RepText = repText;
        }
    }
}