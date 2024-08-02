using System.Collections.Generic;

namespace WPFTraining.Entites
{
    public class Question
    {
        public int Id { get; set; }

        public string Enonce { get; set; }

        public List<Reponse> Reponses { get; set; }

        public bool ChoixMultiple { get; set; }

        public Question()
        {
            Reponses = new List<Reponse>();
        }

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                   Id == question.Id;
        }
    }
}