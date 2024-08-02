using _1_DemoApi.DTO;
using _1_DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DemoApi.Repositories
{
    public interface IUserRepository
    {
        User FindbyEmail(string email);
        List<User> FindAll();
        void Save(User u);
        User FindById(int id);
        void Delete(int id);
        void Update(User u);
        List<User> FindByEmailOrName(string searchField);
        
    }
}
