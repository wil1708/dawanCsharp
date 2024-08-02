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
        //Dépendance du DAO
        IUser dao;

        //Injection de la dépendance dans le constructeur
        public UserService(IUser dao)
        {
            this.dao = dao;
        }

        public void RemoveByLogin(string login)
        {
            dao.DeleteByLogin(login);
        }

        public void AddUser(User u)
        {
            u.Password = HashTools.hashPassword(u.Password);
            dao.Insert(u); 
        }

        public void UpdateUser(User u)
        {
            //Vérifier si le password modifié
            User userBDD = dao.FindByLogin(u.Login);
            if (!userBDD.Password.Equals(u.Password))
            {
                u.Password = HashTools.hashPassword(u.Password);
            }
            
            dao.Update(u);
        }

        internal bool IsUserAdmin(string login)
        {
            bool isAdmin = false;
            User u = dao.FindByLogin(login);
            if (u.Profile.Equals(Profile.ADMIN))
            {
                isAdmin = true;
            }

            return isAdmin;
        }

        public bool CheckLogin(string login, string password)
        {
            bool exist = false;
            User u = dao.FindByLogin(login);
            if(u != null)
            {
                if (u.Password.Equals(HashTools.hashPassword(password)))
                {
                    exist = true;
                }
            }

            return exist;
        }

        public User GetByLogin(string login)
        {
            return dao.FindByLogin(login);
        }

        public List<User> FindAllUser()
        {
            return dao.GetAll();
        }
    }
}
