using _1_DemoApi.DTO;
using _1_DemoApi.Models;
using _1_DemoApi.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _1_DemoApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MyContext db;

        public UserRepository(MyContext db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            var user = db.Users.Find(id);
            if(user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }      
        }

        public List<User> FindAll()
        {
            return db.Users.AsNoTracking().ToList(); 
        }

        public User FindbyEmail(string email)
        {
                return db.Users.Where(u => u.Email.Equals(email)).AsNoTracking().FirstOrDefault();
                
        }

        public List<User> FindByEmailOrName(string searchfield)
        {
            return db.Users.AsNoTracking().Where(u => u.Name.ToLower().Contains(searchfield) || u.Email.ToLower().Contains(searchfield)).ToList();
        }

        public User FindById(int id)
        {
                return db.Users.AsNoTracking().SingleOrDefault(u => u.Id == id);  
        }

        public void Save(User u)
        {           
            db.Users.Add(u);
            db.SaveChanges();          
        }

        public void Update(User u)
        {
            db.Entry(u).State = EntityState.Modified;
            db.SaveChanges();
        }

        
    }
}