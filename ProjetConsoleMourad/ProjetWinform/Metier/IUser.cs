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
        List<User> getAll();
        void Update(User u);
        void deleteByLogin(string login);
        void Insert(User u);
        User findByLogin(string login);

    }
}
//Camel case (méthodes): noms composés : commencer par une miniscule
//Pascal case(classes - interfaces): noms composés : commencer par une majuscule