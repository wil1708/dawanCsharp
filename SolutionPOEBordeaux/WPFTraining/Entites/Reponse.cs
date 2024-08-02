namespace WPFTraining.Entites
{
    public class Reponse
    {
        public int Id { get; set; }

        public string Texte { get; set; }

        public bool Correcte { get; set; }

        public Reponse()
        {
        }

        public Reponse(int id, string texte, bool correcte)
        {
            Id = id;
            Texte = texte;
            Correcte = correcte;
        }

        public override bool Equals(object obj)
        {
            return obj is Reponse reponse &&
                   Id == reponse.Id;
        }

        public override string ToString()
        {
            return Texte;
        }
    }
}