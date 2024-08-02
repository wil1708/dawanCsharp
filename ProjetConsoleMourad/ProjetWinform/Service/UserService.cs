using ProjetWinform.DAO;
using ProjetWinform.Metier;
using ProjetWinform.Model;
using ProjetWinform.MyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Service
{
    public class UserService
    {
        //Dépendence du DAO
        IUser dao;

        //Injection de la dependence dans le contructeur
        public UserService(IUser dao)
        {
            this.dao = dao;
        }

        public void removeByLogin(string login)
        {
            dao.deleteByLogin(login);
        }

        public void addUser(User u)
        {
            u.Password = HashTool.hashPassword(u.Password);
            dao.Insert(u);
        }

        public void updateUser(User u)
        {
            //Vérifier si password modifié
            User userBDD = dao.findByLogin(u.Login);
            if (!userBDD.Password.Equals(u.Password))
            {
                u.Password = HashTool.hashPassword(u.Password);
            }

            dao.Update(u);
        }

        public bool checkLogin(string login, string password)
        {
            bool exist = false;
            User u =dao.findByLogin(login);
            if(u != null)
            {
                if (u.Password.Equals(HashTool.hashPassword(password)))
                {
                    exist = true;
                }
            }

            return exist;
        }

        internal bool isUserAdmin(string login)
        {
            bool isAdmin = false;
            User u = dao.findByLogin(login);
            if (u.Profil.Equals(Profile.ADMIN))
            {
                isAdmin = true;
            }
            return isAdmin;
        }

        public User getByLogin(string login)
        {
            return dao.findByLogin(login);
        }

        public List<User> findAllUser()
        {
            return dao.getAll();
        }


    }
}
