using _1_DemoApi.Models;
using System.Collections.Generic;

namespace _1_DemoApi.Repositories
{
    public interface IContactRepository
    {
        void Delete(int id);
        Contact FindById(int id);
        List<Contact> GetAll();
        void Insert(Contact c);
        void Update(Contact c);
    }
}