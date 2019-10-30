using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;

namespace Library.Services
{
    class OrderService
    {
        private readonly LibraryContext _libraryContext;
        public OrderService()
        {
            _libraryContext = new LibraryContext();
        }
        public void Add(Order order)
        {
            _libraryContext.Orders.Add(order);
            _libraryContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            _libraryContext.Orders.Remove(order);
            _libraryContext.SaveChanges();
        }

        public List<Order> Orders()
        {
            return _libraryContext.Orders.Include("Book").Include("Client").ToList();
        }
        public Order Find(int id)
        {
            Order order = _libraryContext.Orders.Include("Book").FirstOrDefault(b=>b.Id==id);
            return order;

        }
    }
}
