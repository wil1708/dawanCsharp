using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraining.Entites
{
    public class Qcm
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public List<Question> Questions { get; set; }

        public Qcm()
        {
            Questions = new List<Question>();
        }

        public override bool Equals(object obj)
        {
            return obj is Qcm qcm &&
                   Id == qcm.Id;
        }
    }
}
