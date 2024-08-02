using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.LiskovSubstitution.Good2
{
    public class Enfant : Parent
    {
        //Garantir l'obtention du mm password
       
        //SFD ; spécification fonctionnelles détaillées: 
        public virtual string getUser()
        {
            return ConfigurationManager.AppSettings.Get("user");
        }

        public override string getPassword()
        {
            return base.getPassword();
        }
    }
}
