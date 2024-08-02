using _1_DemoApi.DTO;
using _1_DemoApi.Models;
using _1_DemoApi.Repositories;
using _1_DemoApi.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_DemoApi.Services
{
    public class UserService
    {
        private IUserRepository repo;

        public UserService(IUserRepository repo)
        {
            this.repo = repo;
        }

        public void Save(User u)
        {
            u.Password = HashTool.Crypt(u.Password); //crypter le password avant insertion
            repo.Save(u);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }
        public List<User> FindAll()
        {
            return repo.FindAll();
        }

        public User FindbyEmail(string email)
        {
            return repo.FindbyEmail(email);
        }

        public List<User> FindByEmailOrName(string searchField)
        {
            return repo.FindByEmailOrName(searchField);
        }

        public User FindById(int id)
        {
            return repo.FindById(id);
        }

        public void Update(User u)
        {
            //Vérifier la modification du password - si le user a modifié le password dns l'interface - hasher le password
            User userBD = FindById(u.Id);
            if (!userBD.Password.Equals(u.Password))
            {
                u.Password = HashTool.Crypt(u.Password);
            }
            repo.Update(u);
        }

        public User CheckLogin(string email, string password)
        {
            //Vérifier si le user existe en base - return user - sinon return null
            User u = repo.FindbyEmail(email);
            string pwdCrypte = HashTool.Crypt(password);
            if(u == null || !u.Password.Equals(pwdCrypte))
            {
                return null;
            }
            return u;

        }
    }
}