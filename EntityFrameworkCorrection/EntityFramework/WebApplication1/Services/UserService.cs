using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class UserService
    {
        UserRepository repo = new UserRepository();

        public List<Contact> findAll()
        {
            return repo.getAll();
        }
    }
}