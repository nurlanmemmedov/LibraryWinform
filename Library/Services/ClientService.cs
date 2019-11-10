using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;

namespace Library.Services
{
    class ClientService
    {
        private readonly LibraryContext _libraryContext;
        public ClientService()
        {
            _libraryContext = new LibraryContext();
        }
        public void Add(Client client)//adding given client
        {
            _libraryContext.Clients.Add(client);
            _libraryContext.SaveChanges();
        }
        public void Delete(Client client)//deleting given client
        {
            _libraryContext.Clients.Remove(client);
            _libraryContext.SaveChanges();
        }
        public void Update(Client client)//updating given client
        {
            _libraryContext.Entry(client).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }
        public List<Client> Clients()//brings the all  clients
        {
            return _libraryContext.Clients.ToList();
        }
        public Client Find(int id)//find the client according to given Id
        {
            Client client = _libraryContext.Clients.Find(id);
            return client;
        }
    }
}
