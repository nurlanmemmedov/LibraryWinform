using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;

namespace Library.Services
{
    class ManagerService
    {
        private readonly LibraryContext _libraryContext;
        public ManagerService()
        {
            _libraryContext = new LibraryContext();
        }
        public void Add(Manager manager)
        {
            _libraryContext.Managers.Add(manager);
            _libraryContext.SaveChanges();
        }
        public void Delete(Manager manager)
        {
            _libraryContext.Managers.Remove(manager);
            _libraryContext.SaveChanges();
        }
        public void Update(Manager manager)
        {
            _libraryContext.Entry(manager).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }
        public List<Manager> Managers()
        {
            return _libraryContext.Managers.ToList();
        }
        public Manager Find(int id)
        {
            Manager manager =  _libraryContext.Managers.Find(id);
            return manager;
        }
        public int Login(string username, string password)
        {
            Manager manager = null;
            int Id = -1;
            manager = _libraryContext.Managers.FirstOrDefault(a => a.Username == username && a.Password == password);
            if (manager != null)
            {
                Id = manager.Id;
            }
            else
            {
                Id = -1;
            }
            return Id;
        }
    }
}
