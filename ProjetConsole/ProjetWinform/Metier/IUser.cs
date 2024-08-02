using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Metier
{
    public interface IUser
    {
        List<User> GetAll();
        void Update(User u);
        void DeleteByLogin(string login);
        void Insert(User u);
        User FindByLogin(string login);
    }
}
