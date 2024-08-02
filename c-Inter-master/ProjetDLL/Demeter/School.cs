using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Demeter
{
   public  class School
    {
        public List<Grade> Grades { get; set; }

        //Connaitre le nombre de Student des cette école

        //Méthode qui ne respecte pas la loi Demeter - Elle fait appelle à des classes qui ne font parties de ses membres
        public int countStudents()
        {
            int count = 0;
            foreach (Grade grade in Grades)
            {
                foreach (StudentClasse stClasse in grade.Classes)
                {
                    foreach (Student st in stClasse.Students)
                    {
                        count++;
                    }
                }
            }


            return count;
        }

        //Solution
        public int countStudents2()
        {
            int count = 0;

            foreach (Grade grade in Grades)
            {
                count += grade.countStudents();
            }

            return count;
        }
    }
}
