using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Demeter
{
    public class Grade
    {
        public List<StudentClasse> Classes { get; set; }

        public int countStudents()
        {
            int count = 0;
            foreach (StudentClasse stClasse in Classes)
            {
                count += stClasse.countStudents();
            }
            return count;
        }
    }
}
