using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.LiskovSubstitution.Good2
{
    public class Parent
    {
        public virtual string getPassword()
        {
            string pass = ConfigurationManager.AppSettings.Get("pass");
            return pass;
        }
    }
}
