using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Demeter
{
    public class StudentClasse
    {
        public List<Student> Students { get; set; }

        public int countStudents()
        {
            return Students.Count;
        }
    }
}
