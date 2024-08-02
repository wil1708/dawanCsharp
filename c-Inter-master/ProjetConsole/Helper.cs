using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="modif"></param>
        /// <returns></returns>
        public static List<Employe> modifList(List<Employe> lst, Func<List<Employe>, List<Employe>> modif  )
        {
            return modif(lst);
        }

        public static List<Employe> modifList2(List<Employe> lst, string modif)
        {
            if (modif.Equals("ajout"))
            {
                lst.Add(new Employe());
            }
            return lst;
        }
    }
}
