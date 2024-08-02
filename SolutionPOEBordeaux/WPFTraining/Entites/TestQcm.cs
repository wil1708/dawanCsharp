using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraining.Entites
{
    public class TestQcm
    {
        public int Id { get; set; }

        public Candidat Candidat { get; set; }

        public Qcm Qcm { get; set; }

        public DateTime DatePassage { get; set; }

        public int Score { get; set; }

        public TestQcm()
        {
            DatePassage = DateTime.Now;
        }

        public TestQcm(int id, Candidat candidat, Qcm qcm, DateTime datePassage, int score)
        {
            Id = id;
            Candidat = candidat;
            Qcm = qcm;
            DatePassage = datePassage;
            Score = score;
        }

        public override bool Equals(object obj)
        {
            return obj is TestQcm qcm &&
                   Id == qcm.Id;
        }
    }
}
