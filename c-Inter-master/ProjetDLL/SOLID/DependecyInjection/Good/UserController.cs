using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.DependecyInjection.Good
{
    public class UserController
    {
        private IService service;

        public UserController(IService service)
        {
            this.service = service;
        }

        public void UserManager(int id)
        {

        }
    }
}
