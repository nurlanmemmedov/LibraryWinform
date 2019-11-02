using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;

namespace Library.Services
{
    class AdminService
    {
        private readonly LibraryContext _libraryContext;
        public AdminService()
        {
            _libraryContext = new LibraryContext();
        }
        public int Login(string username, string password)
        {
            Admin admin = new Admin();
            int index = -1;
            admin = _libraryContext.Admins.FirstOrDefault(a=>a.Username == username&&a.Password == password);
            if(admin != null)
            {
                index = admin.Id;
            }
            else
            {
                index = -1;
            }
            return index;
        }
    }
}
