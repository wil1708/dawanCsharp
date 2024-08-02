using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.DependecyInjection.Good
{
    public class UserServiceSQL : IService
    {
        private IRepository repo;

        public UserServiceSQL(IRepository repo)
        {
            this.repo = repo;
        }

        public object TraiterUser(int id)
        {
            return null;
        }
    }
}
