using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.DependecyInjection.Good
{
    public class UserRepository : IRepository
    {
        private Context context = new Context();

        public User getById(int id)
        {
            //context.Add(getById(id));
            return context.getById(id);
        }
    }
}
