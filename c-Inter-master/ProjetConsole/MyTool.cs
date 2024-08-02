using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public static class MyTool
    {
        public static string changeFirstChar(string chaine)
        {
            char[] charTab = chaine.ToCharArray();
            //if (char.IsUpper(charTab[0]))
            //{
            //    charTab[0] = char.ToLower(charTab[0]);
            //}
            //else
            //{
            //    charTab[0] = char.ToUpper(charTab[0]);
            //}

            charTab[0] = char.IsUpper(charTab[0]) ? char.ToLower(charTab[0]) : char.ToUpper(charTab[0]);
            return new string(charTab);


        }
    }
}
/*
 * 
 * if(condition)? conditionVraie : conditionFalse
 */